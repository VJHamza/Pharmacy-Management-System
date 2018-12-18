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
    public partial class SaleReport : Form
    {
        public SaleReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            sql.Open();
            string query = "Select InvoiceID,RecordID,MedName,Quantity,SalePrice from RecordTable where InvoiceID IN (Select InvoiceID from SaleMEdToCustomer where (Date between '"+dateTimePicker1.Value.ToString()+"' And '"+dateTimePicker2.Value.ToString()+"'))";
            SqlDataAdapter sda = new SqlDataAdapter(query, sql);

            SqlCommand cmd = new SqlCommand("select sum(SalePrice) From RecordTable where InvoiceID IN (Select InvoiceID from SaleMEdToCustomer where (Date between '" + dateTimePicker1.Value.ToString() + "' And '" + dateTimePicker2.Value.ToString() + "'))", sql);
            double price = Convert.ToDouble(cmd.ExecuteScalar());
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + price);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
