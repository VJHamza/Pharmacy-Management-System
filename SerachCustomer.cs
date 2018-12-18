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
    public partial class SerachCustomer : Form
    {
        public SerachCustomer()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "InvoiceID")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                SqlDataAdapter DA = new SqlDataAdapter("SELECT RecordID,InvoiceID, MedName, Quantity FROM RecordTable ",CONN);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                dataGridView1.DataSource = dt;
                CONN.Close();
            }
            else if (comboBox1.Text == "CustomerName")
            {
                 SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                SqlDataAdapter DA = new SqlDataAdapter("SELECT        RecordTable.RecordID, RecordTable.InvoiceID, SaleMedToCustomer.CustomerName, RecordTable.MedName, RecordTable.Quantity FROM            RecordTable INNER JOIN SaleMedToCustomer ON RecordTable.InvoiceID = SaleMedToCustomer.InvoiceID ", CONN);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                dataGridView1.DataSource = dt;
                CONN.Close();

            }
            else if (comboBox1.Text == "Phone#")
            {
                 SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                SqlDataAdapter DA = new SqlDataAdapter("SELECT RecordTable.RecordID, RecordTable.InvoiceID, SaleMedToCustomer.CustomerName, RecordTable.MedName, RecordTable.Quantity,SaleMedtocustomer.Phone# FROM            RecordTable INNER JOIN SaleMedToCustomer ON RecordTable.InvoiceID = SaleMedToCustomer.InvoiceID WHERE        (RecordTable.InvoiceID IN  (SELECT  InvoiceID  FROM  SaleMedToCustomer AS SaleMedToCustomer_1 WHERE        (Phone# = '" + textBox1.Text + "')))", CONN);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                dataGridView1.DataSource = dt;
                CONN.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "InvoiceID")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                SqlDataAdapter DA = new SqlDataAdapter("SELECT InvoiceID,RecordID, MedName, Quantity FROM RecordTable WHERE (InvoiceID = '" + textBox1.Text + "')", CONN);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                dataGridView1.DataSource = dt;
                CONN.Close();
            }
            else if (comboBox1.Text == "CustomerName")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                SqlDataAdapter DA = new SqlDataAdapter("SELECT        RecordTable.RecordID, RecordTable.InvoiceID, SaleMedToCustomer.CustomerName, RecordTable.MedName, RecordTable.Quantity FROM            RecordTable INNER JOIN SaleMedToCustomer ON RecordTable.InvoiceID = SaleMedToCustomer.InvoiceID WHERE        (RecordTable.InvoiceID IN  (SELECT  InvoiceID  FROM  SaleMedToCustomer AS SaleMedToCustomer_1 WHERE        (CustomerName like '%"+textBox1.Text+"%')))", CONN);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                dataGridView1.DataSource = dt;
                CONN.Close();

            }
            else if (comboBox1.Text == "Phone#")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                SqlDataAdapter DA = new SqlDataAdapter("SELECT        RecordTable.RecordID, RecordTable.InvoiceID, SaleMedToCustomer.CustomerName, RecordTable.MedName, RecordTable.Quantity,Salemedtocustomer.Phone# FROM            RecordTable INNER JOIN SaleMedToCustomer ON RecordTable.InvoiceID = SaleMedToCustomer.InvoiceID WHERE        (RecordTable.InvoiceID IN  (SELECT  InvoiceID  FROM  SaleMedToCustomer AS SaleMedToCustomer_1 WHERE        (Phone# = '" + textBox1.Text + "')))", CONN);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                dataGridView1.DataSource = dt;
                CONN.Close();
            }
       }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffForm sf = new StaffForm();
            sf.Show();
        }
    }
}
