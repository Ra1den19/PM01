using OfficeOpenXml;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            LoadDataInventory();
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

        private void LoadDataInventory()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select DateEvent as Дата, Lastname as Фамилия, Firstname as Имя, Results as Результаты from Inventory inner join Employees on Inventory.Responsible = Employees.EmployeeID";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridInvent.DataSource = table;
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
                DataGridViewRow selectedRow = dataGridBar.SelectedRows[0];

                string productName = selectedRow.Cells["Наименование"].Value.ToString();

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(productName, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);

                Bitmap qrCodeImage = qrCode.GetGraphic(5);
                qrCodeImage = ResizeImage(qrCodeImage, 100, 100);

                ImageConverter converter = new ImageConverter();
                byte[] qrCodeBytes = (byte[])converter.ConvertTo(qrCodeImage, typeof(byte[]));

                int productID = Convert.ToInt32(selectedRow.Cells["Код продукта"].Value);

                SaveQRCodeToDatabase(productID, qrCodeBytes);

                pictureQR.Image = qrCodeImage;
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите товар для генерации QR-кода.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("QR-код успешно создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить QR-код", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridBar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridBar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridBar.SelectedRows[0];

                byte[] qrCodeBytes = selectedRow.Cells["QR-код"].Value as byte[];

                if (qrCodeBytes != null && qrCodeBytes.Length > 0)
                {
                    using (var ms = new System.IO.MemoryStream(qrCodeBytes))
                    {
                        Image qrCodeImage = Image.FromStream(ms);
                        pictureQR.Image = ResizeImage(qrCodeImage, 100, 100);
                    }
                }
                else
                {
                    pictureQR.Image = null;
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

        private void SaveDataInventoryToExcel()
        {
            string connectionString = DataBaseConfig.connectionString;
            string query = "SELECT DateEvent as Дата, Lastname as Фамилия, Firstname as Имя, Results as Результаты " +
                           "FROM Inventory " +
                           "INNER JOIN Employees ON Inventory.Responsible = Employees.EmployeeID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(com))
                    {
                        DataTable table = new DataTable();
                        ad.Fill(table);

                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("InventoryData");

                            for (int i = 0; i < table.Columns.Count; i++)
                            {
                                worksheet.Cells[1, i + 1].Value = table.Columns[i].ColumnName;
                            }

                            for (int i = 0; i < table.Rows.Count; i++)
                            {
                                for (int j = 0; j < table.Columns.Count; j++)
                                {
                                    if (table.Columns[j].ColumnName == "Дата" && table.Rows[i][j] is DateTime)
                                    {
                                        worksheet.Cells[i + 2, j + 1].Style.Numberformat.Format = "dd.MM.yyyy"; // Формат даты
                                        worksheet.Cells[i + 2, j + 1].Value = ((DateTime)table.Rows[i][j]).ToString("dd.MM.yyyy");
                                    }
                                    else
                                    {
                                        worksheet.Cells[i + 2, j + 1].Value = table.Rows[i][j];
                                    }
                                }
                            }

                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                            {
                                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                                saveFileDialog.FileName = "InventoryData.xlsx";
                                saveFileDialog.Title = "Сохранить файл Excel";

                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    string filePath = saveFileDialog.FileName;
                                    FileInfo excelFile = new FileInfo(filePath);
                                    excelPackage.SaveAs(excelFile);

                                    MessageBox.Show($"Файл успешно сохранен: {filePath}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Сохранение отменено.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void exportExcelButton_Click(object sender, EventArgs e)
        {
            SaveDataInventoryToExcel();
        }
    }
}
