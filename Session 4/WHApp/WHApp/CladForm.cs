using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHApp
{
    public partial class CladForm : Form
    {
        public CladForm()
        {
            InitializeComponent();
            LoadDataIncoming();
            LoadDataExpenditure();
            LoadDataProducts();
        }

        private void LoadDataIncoming()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select InvoiceNumber as [Номер накладной], DateReceipt as [Дата получения], SupplierID as [Код поставщика], ProductsList as [Список товаров], TotalAmount as [Общая сумма] from IncomingInvoices";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridIncInv.DataSource = table;
        }

        private void LoadDataExpenditure()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select InvoiceNumber as [Номер накладной], ShippingDate as [Дата отгрузки], ClientID as [Код клиента], ProductsList as [Список товаров], TotalAmount as [Общая сумма] from ExpenditureInvoices";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridExpInv.DataSource = table;
        }

        private void LoadDataProducts()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select ProductID as [Код продукта], Name as Наименование, Article as Артикул, Barcode as [QR-код], Category as Категория, UnitOfMeasurement as [Единица измерения], UnitPrice as [Цена за единицу], SerialNumber as [Серийный номер], MinBalance as [Минимальный остаток] from Products";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridBar.DataSource = table;
            dataGridBar.Columns["QR-код"].Visible = false;
        }

        private void addIncomingButton_Click(object sender, EventArgs e)
        {
            AddIncomingForm aif = new AddIncomingForm();
            aif.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            LoadDataIncoming();
        }

        private void updateExpenditureButton_Click(object sender, EventArgs e)
        {
            LoadDataExpenditure();
        }

        private void addExpenditureButton_Click(object sender, EventArgs e)
        {
            AddExpenditureForm aef = new AddExpenditureForm();
            aef.ShowDialog();
        }

        private void addQRButton_Click(object sender, EventArgs e)
        {
            if (dataGridBar.SelectedRows.Count > 0)
            {
                // Получаем выбранную строку
                DataGridViewRow selectedRow = dataGridBar.SelectedRows[0];

                // Получаем наименование товара (предположим, что у вас есть столбец "ProductName")
                string productName = selectedRow.Cells["Наименование"].Value.ToString();

                // Генерируем QR-код на основе наименования товара
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(productName, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);

                // Генерируем изображение QR-кода с размером 100x100 пикселей
                Bitmap qrCodeImage = qrCode.GetGraphic(5); // Увеличиваем количество пикселей на модуль
                qrCodeImage = ResizeImage(qrCodeImage, 100, 100); // Масштабируем до 100x100

                // Конвертируем изображение QR-кода в массив байтов
                ImageConverter converter = new ImageConverter();
                byte[] qrCodeBytes = (byte[])converter.ConvertTo(qrCodeImage, typeof(byte[]));

                // Получаем ID товара для обновления записи в базе данных
                int productID = Convert.ToInt32(selectedRow.Cells["Код продукта"].Value);

                // Сохраняем QR-код в базу данных
                SaveQRCodeToDatabase(productID, qrCodeBytes);

                // Обновляем pictureBox, чтобы отобразить новый QR-код
                pictureQR.Image = qrCodeImage;
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите товар для генерации QR-кода.");
            }
        }

        private void SaveQRCodeToDatabase(int productID, byte[] qrCodeBytes)
        {
            string connectionString = DataBaseConfig.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Products SET Barcode = @Barcode WHERE ProductID = @ProductID";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@Barcode", qrCodeBytes);
                com.Parameters.AddWithValue("@ProductID", productID);

                con.Open();
                int result = com.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("QR-код успешно сохранен в базе данных.");
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить QR-код.");
                }
            }
        }

        private void dataGridBar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridBar.SelectedRows.Count > 0)
            {
                // Получаем выбранную строку
                DataGridViewRow selectedRow = dataGridBar.SelectedRows[0];

                // Получаем данные QR-кода из столбца Barcode
                byte[] qrCodeBytes = selectedRow.Cells["QR-код"].Value as byte[];

                // Если QR-код существует, отображаем его в pictureBox
                if (qrCodeBytes != null && qrCodeBytes.Length > 0)
                {
                    // Конвертируем массив байтов в изображение
                    using (var ms = new System.IO.MemoryStream(qrCodeBytes))
                    {
                        Image qrCodeImage = Image.FromStream(ms);
                        // Масштабируем изображение до 100x100 пикселей
                        pictureQR.Image = ResizeImage(qrCodeImage, 100, 100);
                    }
                }
                else
                {
                    pictureQR.Image = null; // Очищаем pictureBox, если QR-код отсутствует
                }
            }
        }

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void updateQRButton_Click(object sender, EventArgs e)
        {
            LoadDataProducts();
        }
    }
}
