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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            LoadDataProductsInWarehouses();
            LoadDataIncomingInvoices();
            LoadDataExpenditureInvoices();
            LoadDataSuppliersOrders();
            LoadDataClientsOrders();
            LoadDataClients();
            LoadDataSuppliers();
        }

        private void LoadDataProductsInWarehouses()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select Products.Name as [Наименование продукта], Warehouses.Name as [Наименование склада], Quantity as [Количество] from ProductsInWarehouses inner join Products on Products.ProductID = ProductsInWarehouses.ProductID inner join Warehouses on Warehouses.WarehouseID = ProductsInWarehouses.WarehouseID";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridProductsInWarehouses.DataSource = table;
        }

        private void LoadDataSuppliersOrders()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select SupplierID as [Код поставщика], ProductID as [Код товара], Name as [Наименование заказа], QuantityProduct as [Количество товара] from SuppliersOrders";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridSuppliersOrders.DataSource = table;
        }

        private void LoadDataClientsOrders()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select ClientID as [Код клиента], ProductID as [Код товара], Name as [Наименование заказа], QuantityProduct as [Количество товара] from ClientsOrders";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridClientsOrders.DataSource = table;
        }

        private void LoadDataIncomingInvoices()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select InvoiceNumber as [Номер накладной], DateReceipt as [Дата получения], SupplierID as [Код поставщика], ProductsList as [Список товаров], TotalAmount as [Общая сумма] from IncomingInvoices";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridIncoming.DataSource = table;
        }

        private void LoadDataExpenditureInvoices()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select InvoiceNumber as [Номер накладной], ShippingDate as [Дата отгрузки], ClientID as [Код клиента], ProductsList as [Список товаров], TotalAmount as [Общая сумма] from ExpenditureInvoices";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridExpenditure.DataSource = table;
        }

        private void updateWarehousesButton_Click(object sender, EventArgs e)
        {
            LoadDataProductsInWarehouses();
        }

        private void updateInvoicesButton_Click(object sender, EventArgs e)
        {
            LoadDataIncomingInvoices();
            LoadDataExpenditureInvoices();
        }

        private void addOrderToClientButton_Click(object sender, EventArgs e)
        {
            AddOrderToClientForm ocf = new AddOrderToClientForm();
            ocf.ShowDialog();
        }

        private void addOrderToSupplierButton_Click(object sender, EventArgs e)
        {
            AddOrderToSupplierForm osf = new AddOrderToSupplierForm();
            osf.ShowDialog();
        }

        private void updateClientsOrdersButton_Click(object sender, EventArgs e)
        {
            LoadDataClientsOrders();
        }

        private void updateSuppliersOrdersButton_Click(object sender, EventArgs e)
        {
            LoadDataSuppliersOrders();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string name = textSearchSup.Text.Trim();
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select SupplierID as [Код поставщика], ProductID as [Код товара], Name as [Наименование заказа], QuantityProduct as [Количество товара] from SuppliersOrders where Name like '%{name}%'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridSuppliersOrders.DataSource = table;
        }

        private void textSearchClient_TextChanged(object sender, EventArgs e)
        {
            string name = textSearchClient.Text.Trim();
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select ClientID as [Код клиента], ProductID as [Код товара], Name as [Наименование заказа], QuantityProduct as [Количество товара] from ClientsOrders where Name like '%{name}%'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridSuppliersOrders.DataSource = table;
        }

        private void textSearchInc_TextChanged(object sender, EventArgs e)
        {
            string number = textSearchInc.Text.Trim();
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select InvoiceNumber as [Номер накладной], DateReceipt as [Дата получения], SupplierID as [Код поставщика], ProductsList as [Список товаров], TotalAmount as [Общая сумма] from IncomingInvoices where InvoiceNumber like '%{number}%'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridIncoming.DataSource = table;
        }

        private void textSearchExp_TextChanged(object sender, EventArgs e)
        {
            string number = textSearchExp.Text.Trim();
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select InvoiceNumber as [Номер накладной], ShippingDate as [Дата отгрузки], ClientID as [Код клиента], ProductsList as [Список товаров], TotalAmount as [Общая сумма] from ExpenditureInvoices where InvoiceNumber like '%{number}%'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridExpenditure.DataSource = table;
        }

        private void textSearchWarehouse_TextChanged(object sender, EventArgs e)
        {
            string warehouse = textSearchWarehouse.Text.Trim();
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select Products.Name as [Наименование продукта], Warehouses.Name as [Наименование склада], Quantity as [Количество] from ProductsInWarehouses inner join Products on Products.ProductID = ProductsInWarehouses.ProductID inner join Warehouses on Warehouses.WarehouseID = ProductsInWarehouses.WarehouseID where Warehouses.Name like '%{warehouse}%'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridProductsInWarehouses.DataSource = table;
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            AddClientForm cf = new AddClientForm();
            cf.ShowDialog();
        }

        private void LoadDataClients()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select Name as Имя, ContactDetails as [Контактные данные], Address as Адрес from Clients";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridClients.DataSource = table;
        }

        private void addSupplierButton_Click(object sender, EventArgs e)
        {
            AddSupplierForm sf = new AddSupplierForm();
            sf.ShowDialog();
        }

        private void LoadDataSuppliers()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select Name as Название, INN as ИНН, ContactDetails as [Контактные данные], Address as Адрес from Suppliers";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridSuppliers.DataSource = table;
        }

        private void updateSuppliersButton_Click(object sender, EventArgs e)
        {
            LoadDataSuppliers();
        }

        private void updateClientsButton_Click(object sender, EventArgs e)
        {
            LoadDataClients();
        }
    }
}
