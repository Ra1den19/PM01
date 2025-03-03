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
    public partial class AddExpenditureForm : Form
    {
        public AddExpenditureForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string num = textNumber.Text;
            string date = textDate.Text;
            string code = textCode.Text;
            string list = textList.Text;
            string amount = textAmount.Text;
            string connectionString = DataBaseConfig.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"insert into ExpenditureInvoices(InvoiceNumber, ShippingDate, ClientID, ProductsList, TotalAmount) values('{num}', '{date}', '{code}', '{list}', '{amount}')";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            MessageBox.Show("Расходная накладная оформлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
