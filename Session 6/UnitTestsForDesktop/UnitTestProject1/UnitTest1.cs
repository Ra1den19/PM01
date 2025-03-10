using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.SqlClient;
using WHApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private string connectionString = DataBaseConfig.connectionString;

        [TestMethod]
        public void TestLoadDataInventory_ReturnsData()
        {
            var form = new BuhgalterForm();
            bool dataLoaded = false;

            form.LoadDataInventory();

            if (form.dataGridInventory.DataSource != null)
            {
                DataTable dataTable = (DataTable)form.dataGridInventory.DataSource;
                if (dataTable.Rows.Count > 0)
                {
                    dataLoaded = true;
                }
            }

            Assert.IsTrue(dataLoaded, "Данные должны быть загружены в DataGrid.");
        }

        [TestMethod]
        public void TestLoadDataInventory_CheckColumns()
        {
            var form = new BuhgalterForm();

            form.LoadDataInventory();

            DataTable dataTable = (DataTable)form.dataGridInventory.DataSource;
            bool columnsMatch = dataTable.Columns.Contains("Дата события") &&
                               dataTable.Columns.Contains("Ответственный") &&
                               dataTable.Columns.Contains("Результаты");

            Assert.IsTrue(columnsMatch, "Колонки DataGrid должны соответствовать запросу.");
        }

        [TestMethod]
        public void TestLoadDataInventory_CheckData()
        {
            var form = new BuhgalterForm();

            form.LoadDataInventory();

            DataTable dataTable = (DataTable)form.dataGridInventory.DataSource;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "select DateEvent as [Дата события], Lastname as Ответственный, Results as Результаты from Inventory inner join Employees on Inventory.Responsible = Employees.EmployeeID";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataAdapter ad = new SqlDataAdapter(com);
                DataTable expectedTable = new DataTable();
                ad.Fill(expectedTable);

                Assert.AreEqual(expectedTable.Rows.Count, dataTable.Rows.Count, "Количество строк в DataGrid должно совпадать с данными из базы.");

                if (expectedTable.Rows.Count > 0 && dataTable.Rows.Count > 0)
                {
                    Assert.AreEqual(expectedTable.Rows[0]["Дата события"], dataTable.Rows[0]["Дата события"], "Данные в первой строке должны совпадать.");
                    Assert.AreEqual(expectedTable.Rows[0]["Ответственный"], dataTable.Rows[0]["Ответственный"], "Данные в первой строке должны совпадать.");
                    Assert.AreEqual(expectedTable.Rows[0]["Результаты"], dataTable.Rows[0]["Результаты"], "Данные в первой строке должны совпадать.");
                }
            }
        }

        [TestMethod]
        public void TestLoadDataOstatkiReport_ReturnsData()
        {
            var form = new BuhgalterForm();
            bool dataLoaded = false;

            form.LoadDataOstatkiReport();

            if (form.dataGridOstatkiReport.DataSource != null)
            {
                DataTable dataTable = (DataTable)form.dataGridOstatkiReport.DataSource;
                if (dataTable.Rows.Count > 0)
                {
                    dataLoaded = true;
                }
            }

            Assert.IsTrue(dataLoaded, "Данные должны быть загружены в DataGrid для отчета об остатках.");
        }

        [TestMethod]
        public void TestLoadDataOstatkiReport_CheckColumns()
        {
            var form = new BuhgalterForm();

            form.LoadDataOstatkiReport();

            DataTable dataTable = (DataTable)form.dataGridOstatkiReport.DataSource;
            bool columnsMatch = dataTable.Columns.Contains("Количество товаров") &&
                               dataTable.Columns.Contains("Наименование склада");

            Assert.IsTrue(columnsMatch, "Колонки DataGrid для отчета об остатках должны соответствовать запросу.");
        }

        [TestMethod]
        public void TestLoadDataOstatkiReport_CheckData()
        {
            var form = new BuhgalterForm();

            form.LoadDataOstatkiReport();

            DataTable dataTable = (DataTable)form.dataGridOstatkiReport.DataSource;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "select Quantity as [Количество товаров], Name as [Наименование склада] from ProductsInWarehouses inner join Warehouses on ProductsInWarehouses.WarehouseID = Warehouses.WarehouseID";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataAdapter ad = new SqlDataAdapter(com);
                DataTable expectedTable = new DataTable();
                ad.Fill(expectedTable);

                Assert.AreEqual(expectedTable.Rows.Count, dataTable.Rows.Count, "Количество строк в DataGrid для отчета об остатках должно совпадать с данными из базы.");

                if (expectedTable.Rows.Count > 0 && dataTable.Rows.Count > 0)
                {
                    Assert.AreEqual(expectedTable.Rows[0]["Количество товаров"], dataTable.Rows[0]["Количество товаров"], "Данные в первой строке должны совпадать.");
                    Assert.AreEqual(expectedTable.Rows[0]["Наименование склада"], dataTable.Rows[0]["Наименование склада"], "Данные в первой строке должны совпадать.");
                }
            }
        }

        [TestMethod]
        public void TestLoadDataOborotsReport_ReturnsData()
        {
            var form = new BuhgalterForm();
            bool dataLoaded = false;

            form.LoadDataOborotsReport();

            if (form.dataGridOborotsReport.DataSource != null)
            {
                DataTable dataTable = (DataTable)form.dataGridOborotsReport.DataSource;
                if (dataTable.Rows.Count > 0)
                {
                    dataLoaded = true;
                }
            }

            Assert.IsTrue(dataLoaded, "Данные должны быть загружены в DataGrid для отчета об оборотах.");
        }

        [TestMethod]
        public void TestLoadDataOborotsReport_CheckColumns()
        {
            var form = new BuhgalterForm();

            form.LoadDataOborotsReport();

            DataTable dataTable = (DataTable)form.dataGridOborotsReport.DataSource;
            bool columnsMatch = dataTable.Columns.Contains("Количество товаров") &&
                               dataTable.Columns.Contains("Наименование склада");

            Assert.IsTrue(columnsMatch, "Колонки DataGrid для отчета об оборотах должны соответствовать запросу.");
        }

        [TestMethod]
        public void TestLoadDataOborotsReport_CheckData_Negative()
        {
            var form = new BuhgalterForm();

            form.LoadDataOborotsReport();

            DataTable dataTable = (DataTable)form.dataGridOborotsReport.DataSource;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string updateQuery = "UPDATE ProductsInWarehouses SET Quantity = Quantity + 1 WHERE WarehouseID = 1"; // Пример изменения данных
                SqlCommand updateCom = new SqlCommand(updateQuery, con);
                updateCom.ExecuteNonQuery();
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "select Quantity as [Количество товаров], Name as [Наименование склада] from ProductsInWarehouses inner join Warehouses on ProductsInWarehouses.WarehouseID = Warehouses.WarehouseID";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataAdapter ad = new SqlDataAdapter(com);
                DataTable expectedTable = new DataTable();
                ad.Fill(expectedTable);

                if (expectedTable.Rows.Count > 0 && dataTable.Rows.Count > 0)
                {
                    Assert.AreNotEqual(expectedTable.Rows[0]["Количество товаров"], dataTable.Rows[0]["Количество товаров"], "Данные в первой строке не должны совпадать (отрицательный тест).");
                    Assert.AreNotEqual(expectedTable.Rows[0]["Наименование склада"], dataTable.Rows[0]["Наименование склада"], "Данные в первой строке не должны совпадать (отрицательный тест).");
                }
                else
                {
                    Assert.Fail("Нет данных для сравнения.");
                }
            }
        }

        [TestMethod]
        public void TestAddButton_Click_EmptyInput()
        {
            var form = new AddProductForm();
            form.textName.Text = "";
            form.textArt.Text = "";
            form.textCat.Text = "";
            form.textIzm.Text = "";
            form.textPrice.Text = "";
            form.textSerial.Text = "";
            form.textMin.Text = "";

            try
            {
                form.AddButton_Click(null, null);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is SqlException || ex is InvalidOperationException, "Ожидалось исключение при пустом вводе.");
                return;
            }

            Assert.Fail("Метод должен был выбросить исключение при пустом вводе.");
        }
    }
}
