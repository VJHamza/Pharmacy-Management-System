using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy
{
    public partial class ExpiryReport : Form
    {
        public ExpiryReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  MedID, MedName, MedCompany, MedCatagory, Quantity, RetailPrice, SupplierID FROM StockTable  WHERE  MedCompany like '" + textBox1.Text + "%' OR (MedID IN (SELECT MedID FROM StockMFG_EXP_DATE  WHERE (ExpDate BETWEEN '" + dateTimePicker1.Value.ToString() + "' AND '" + dateTimePicker2.Value.ToString() + "')))";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm AF = new AdminForm();
            AF.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  MedID, MedName, MedCompany, MedCatagory, Quantity, RetailPrice, SupplierID FROM StockTable  WHERE  MedCompany like '" + textBox1.Text + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
