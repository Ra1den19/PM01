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
    }
}
