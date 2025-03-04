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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string art = textArt.Text;
            string cat = textCat.Text;
            string izm = textIzm.Text;
            string price = textPrice.Text;
            string serial = textSerial.Text;
            string min = textMin.Text;
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"insert into Products(Name, Article, Category, UnitOfMeasurement, UnitPrice, SerialNumber, MinBalance) values('{name}', '{art}', '{cat}', '{izm}', '{price}', '{serial}', '{min}')";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            MessageBox.Show("Товар добавлен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
