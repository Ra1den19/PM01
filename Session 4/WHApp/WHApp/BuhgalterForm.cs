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
    public partial class BuhgalterForm : Form
    {
        public BuhgalterForm()
        {
            InitializeComponent();
            LoadDataInventory();
        }

        private void LoadDataInventory()
        {
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"select DateEvent as [Дата события], Responsible as Ответственный, Results as Результаты from Inventory";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridInventory.DataSource = table;
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
    }
}
