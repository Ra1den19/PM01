using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHApp
{
    public partial class AdminForm : Form
    {
        private readonly HttpClient _httpClient;
        private readonly string _connectionString = DataBaseConfig.connectionString;
        public AdminForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            InitializeListViewWarehouses();
            LoadDataWarehousesAsync();
            InitializeListViewProducts();
            LoadDataProductsAsync();
            InitializeListViewClients();
            LoadDataClientsAsync();
            InitializeListViewSuppliers();
            LoadDataSuppliersAsync();
        }

        private void InitializeListViewWarehouses()
        {
            listWH.View = View.Tile; // Установка режима отображения на плитки
            listWH.FullRowSelect = true;
            listWH.GridLines = false; // Отключение линий сетки для более чистого вида

            // Настройка параметров плитки
            listWH.TileSize = new System.Drawing.Size(200, 100); // Размер плитки
            listWH.Columns.Add("Warehouse ID", 100);
            listWH.Columns.Add("Name", 150);
            listWH.Columns.Add("Address", 200);
            listWH.Columns.Add("Type", 100);
            listWH.Columns.Add("Storage Area", 150);

            // Добавление ImageList для иконок
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32); // Размер иконок
            imageList.Images.Add("WarehouseIcon", Properties.Resources.Warehouse); // Добавление иконки
            listWH.LargeImageList = imageList;
        }

        private void InitializeListViewProducts()
        {
            listProducts.View = View.Tile; // Установка режима отображения на плитки
            listProducts.FullRowSelect = true;
            listProducts.GridLines = false; // Отключение линий сетки для более чистого вида

            // Настройка параметров плитки
            listProducts.TileSize = new System.Drawing.Size(200, 100); // Размер плитки
            listProducts.Columns.Add("Product ID", 100); // Колонка для ID продукта
            listProducts.Columns.Add("Name", 150); // Колонка для названия продукта
            listProducts.Columns.Add("Article", 100); // Колонка для артикула
            listProducts.Columns.Add("Category", 150); // Колонка для категории
            listProducts.Columns.Add("Unit Price", 100); // Колонка для цены
            listProducts.Columns.Add("Min Balance", 100); // Колонка для минимального остатка

            // Добавление ImageList для иконок
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32); // Размер иконок
            imageList.Images.Add("ProductIcon", Properties.Resources.Product); // Добавление иконки
            listProducts.LargeImageList = imageList; // Используем LargeImageList для плиток
        }

        private void InitializeListViewClients()
        {
            listClients.View = View.Tile; // Режим плиток
            listClients.FullRowSelect = true;
            listClients.GridLines = false; // Без линий сетки

            // Настройка размера плиток
            listClients.TileSize = new System.Drawing.Size(200, 100);

            // Настройка колонок
            listClients.Columns.Add("Client ID", 100);
            listClients.Columns.Add("Name", 150);
            listClients.Columns.Add("Contact Details", 200);
            listClients.Columns.Add("Address", 250);

            // Добавление иконок
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);
            imageList.Images.Add("ClientIcon", Properties.Resources.Client);
            listClients.LargeImageList = imageList;
        }

        private void InitializeListViewSuppliers()
        {
            listSuppliers.View = View.Tile; // Установка режима отображения на плитки
            listSuppliers.FullRowSelect = true;
            listSuppliers.GridLines = false; // Отключение линий сетки для более чистого вида

            // Настройка параметров плитки
            listSuppliers.TileSize = new System.Drawing.Size(200, 100); // Размер плитки
            listSuppliers.Columns.Add("Supplier ID", 100); // Колонка для ID поставщика
            listSuppliers.Columns.Add("Name", 150); // Колонка для имени поставщика
            listSuppliers.Columns.Add("Contact Details", 200); // Колонка для контактных данных
            listSuppliers.Columns.Add("Address", 250); // Колонка для адреса

            // Добавление ImageList для иконок
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32); // Размер иконок
            imageList.Images.Add("SupplierIcon", Properties.Resources.Supplier); // Добавление иконки
            listSuppliers.LargeImageList = imageList; // Используем LargeImageList для плиток
        }

        private async Task LoadDataWarehousesAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    var command = new SqlCommand("SELECT WarehouseID, Name, Address, Type, StorageArea FROM Warehouses", connection);
                    var reader = await command.ExecuteReaderAsync();

                    listWH.Items.Clear();

                    while (await reader.ReadAsync())
                    {
                        var item = new ListViewItem(reader["Name"].ToString(), "WarehouseIcon");
                        item.SubItems.Add(reader["WarehouseID"].ToString());
                        item.SubItems.Add(reader["Address"].ToString());
                        item.SubItems.Add(reader["Type"].ToString());
                        item.SubItems.Add(reader["StorageArea"].ToString());
                        listWH.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDataProductsAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    var command = new SqlCommand("SELECT ProductID, Name, Article, Category, UnitPrice, MinBalance FROM Products", connection);
                    var reader = await command.ExecuteReaderAsync();

                    listProducts.Items.Clear();

                    while (await reader.ReadAsync())
                    {
                        var item = new ListViewItem(reader["Name"].ToString());
                        item.SubItems.Add(reader["ProductID"].ToString());
                        item.SubItems.Add(reader["Article"].ToString());
                        item.SubItems.Add(reader["Category"].ToString());
                        item.SubItems.Add(Convert.ToDecimal(reader["UnitPrice"]).ToString("C"));
                        item.SubItems.Add(reader["MinBalance"].ToString());

                        item.ImageKey = "ProductIcon";

                        listProducts.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDataClientsAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    var command = new SqlCommand("SELECT ClientID, Name, ContactDetails, Address FROM Clients", connection);
                    var reader = await command.ExecuteReaderAsync();

                    listClients.Items.Clear();

                    while (await reader.ReadAsync())
                    {
                        var item = new ListViewItem(reader["Name"].ToString());
                        item.SubItems.Add(reader["ClientID"].ToString());
                        item.SubItems.Add(reader["ContactDetails"].ToString());
                        item.SubItems.Add(reader["Address"].ToString());

                        item.ImageKey = "ClientIcon";
                        listClients.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDataSuppliersAsync()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    var command = new SqlCommand("SELECT SupplierID, Name, ContactDetails, Address FROM Suppliers", connection);
                    var reader = await command.ExecuteReaderAsync();

                    listSuppliers.Items.Clear();

                    while (await reader.ReadAsync())
                    {
                        var item = new ListViewItem(reader["Name"].ToString());
                        item.SubItems.Add(reader["SupplierID"].ToString());
                        item.SubItems.Add(reader["ContactDetails"].ToString());
                        item.SubItems.Add(reader["Address"].ToString());

                        item.ImageKey = "SupplierIcon";

                        listSuppliers.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            LoadDataWarehousesAsync();
        }

        private void updateProductsButton_Click(object sender, EventArgs e)
        {
           LoadDataProductsAsync();
        }

        private void updateClientsButton_Click(object sender, EventArgs e)
        {
            LoadDataClientsAsync();
        }

        private void updateSuppliersButton_Click(object sender, EventArgs e)
        {
            LoadDataSuppliersAsync();
        }

        private void addWarehouseButton_Click(object sender, EventArgs e)
        {
            AddWarehouseForm aw = new AddWarehouseForm();
            aw.ShowDialog();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm pf = new AddProductForm();
            pf.ShowDialog();
        }
    }

    public class Warehouse
    {
        public int WarehouseID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string StorageArea { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Article { get; set; }
        public string Barcode { get; set; }
        public string Category { get; set; }
        public string UnitOfMeasurement { get; set; }
        public decimal UnitPrice { get; set; }
        public int SerialNumber { get; set; }
        public int MinBalance { get; set; }
    }

    public class Clients
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }
        public string Address { get; set; }
    }

    public class Suppliers
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public int INN { get; set; }
        public string ContactDetails { get; set; }
        public string Address { get; set; }
    }
}
