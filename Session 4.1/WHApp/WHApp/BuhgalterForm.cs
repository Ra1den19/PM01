using OfficeOpenXml;
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
    public partial class BuhgalterForm : Form
    {
        public BuhgalterForm()
        {
            InitializeComponent();
            LoadDataInventory();
            LoadDataWarehousesReport();
            LoadDataOstatkiReport();
            LoadDataOborotsReport();
        }

        private void LoadDataInventory()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select DateEvent as [Дата события], Lastname as Ответственный, Results as Результаты from Inventory inner join Employees on Inventory.Responsible = Employees.EmployeeID";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridInventory.DataSource = table;
        }

        private void LoadDataWarehousesReport()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select count(WarehouseID) as [Количество складов], Warehouses.Type as [Тип склада], StorageArea as [Зона хранения] from Warehouses group by Warehouses.Type, StorageArea";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridWarehouseReport.DataSource = table;
        }

        private void LoadDataOstatkiReport()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select Quantity as [Количество товаров], Name as [Наименование склада] from ProductsInWarehouses inner join Warehouses on ProductsInWarehouses.WarehouseID = Warehouses.WarehouseID";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridOstatkiReport.DataSource = table;
        }

        private void LoadDataOborotsReport()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select Quantity as [Количество товаров], Name as [Наименование склада] from ProductsInWarehouses inner join Warehouses on ProductsInWarehouses.WarehouseID = Warehouses.WarehouseID";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridOborotsReport.DataSource = table;
        }

        private void addInventoryButton_Click(object sender, EventArgs e)
        {
            AddInventoryForm aif = new AddInventoryForm();
            aif.ShowDialog();
        }

        private void updateInventoryButton_Click(object sender, EventArgs e)
        {
            LoadDataInventory();
        }

        private void updateOstatkiButton_Click(object sender, EventArgs e)
        {
            LoadDataOstatkiReport();
        }

        private void updateOborotsButton_Click(object sender, EventArgs e)
        {
            LoadDataOborotsReport();
        }

        private void updateWarehousesReportButton_Click(object sender, EventArgs e)
        {
            LoadDataWarehousesReport();
        }

        private void ExportWarehousesReportToExcel()
        {
            string connectionString = DataBaseConfig.connectionString;
            string query = "SELECT COUNT(WarehouseID) AS [Количество складов], Warehouses.Type AS [Тип склада], StorageArea AS [Зона хранения] " +
                           "FROM Warehouses " +
                           "GROUP BY Warehouses.Type, StorageArea";

            ExportToExcel(query, "Отчет по складам", "WarehousesReport.xlsx");
        }

        private void ExportOstatkiReportToExcel()
        {
            string connectionString = DataBaseConfig.connectionString;
            string query = "SELECT Quantity AS [Количество товаров], Name AS [Наименование склада] " +
                           "FROM ProductsInWarehouses " +
                           "INNER JOIN Warehouses ON ProductsInWarehouses.WarehouseID = Warehouses.WarehouseID";

            ExportToExcel(query, "Отчет по остаткам", "OstatkiReport.xlsx");
        }

        private void ExportOborotsReportToExcel()
        {
            string connectionString = DataBaseConfig.connectionString;
            string query = "SELECT Quantity AS [Количество товаров], Name AS [Наименование склада] " +
                           "FROM ProductsInWarehouses " +
                           "INNER JOIN Warehouses ON ProductsInWarehouses.WarehouseID = Warehouses.WarehouseID";

            ExportToExcel(query, "Отчет по оборотам", "OborotsReport.xlsx");
        }

        private void ExportToExcel(string query, string sheetName, string defaultFileName)
        {
            using (SqlConnection con = new SqlConnection(DataBaseConfig.connectionString))
            {
                using (SqlCommand com = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(com))
                    {
                        DataTable table = new DataTable();
                        ad.Fill(table);

                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

                            for (int i = 0; i < table.Columns.Count; i++)
                            {
                                worksheet.Cells[1, i + 1].Value = table.Columns[i].ColumnName;
                            }

                            for (int i = 0; i < table.Rows.Count; i++)
                            {
                                for (int j = 0; j < table.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = table.Rows[i][j];
                                }
                            }

                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                            {
                                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                                saveFileDialog.FileName = defaultFileName;
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

        private void exportWarehousesButton_Click(object sender, EventArgs e)
        {
            ExportWarehousesReportToExcel();
        }

        private void exportOborotsButton_Click(object sender, EventArgs e)
        {
            ExportOborotsReportToExcel();
        }

        private void exportOstatkiButton_Click(object sender, EventArgs e)
        {
            ExportOstatkiReportToExcel();
        }
    }
}
