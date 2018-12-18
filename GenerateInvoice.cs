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
    public partial class GenerateInvoice : Form
    {
        public GenerateInvoice(string value,string value1)
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            textBox1.Text=value;
            SqlDataAdapter SDA = new SqlDataAdapter("Select * from RecordTable where InvoiceID= '"+textBox1.Text+"'", conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox2.Text = value1;
            conn.Close();
        }

        private void GenerateInvoice_Load(object sender, EventArgs e)
        {
         
        }
    }
}
