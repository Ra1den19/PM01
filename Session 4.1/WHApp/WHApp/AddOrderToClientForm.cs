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
    public partial class AddOrderToClientForm : Form
    {
        public AddOrderToClientForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string client = textClient.Text;
            string product = textProduct.Text;
            string name = textName.Text;
            string quantity = textQuantity.Text;
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"insert into ClientsOrders(ClientID, ProductID, Name, QuantityProduct) values('{client}', '{product}', '{name}', '{quantity}')";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            MessageBox.Show("Заказ сформирован", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
