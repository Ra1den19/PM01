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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string contact = textContact.Text;
            string address = textAddress.Text;
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"insert into Clients(Name, ContactDetails, Address) values('{name}', '{contact}', '{address}')";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            MessageBox.Show("Клиент добавлен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
