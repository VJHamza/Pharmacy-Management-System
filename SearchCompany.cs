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
    public partial class SearchCompany : Form
    {
        public SearchCompany()
        {
            InitializeComponent();
        }

        private void SearchCompanyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "CompanyName")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                SqlDataAdapter DA = new SqlDataAdapter("SELECT CompanyID, CompanyName, CompanyPhone#, CompanyLocation, Area, Street#, EmailAddress FROM CompanyDetail where CompanyName like'" + SearchCompanyTextBox.Text + "%'", CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                CONN.Close();

            }
            else if (comboBox1.Text == "EmailAddress")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                SqlDataAdapter DA = new SqlDataAdapter("SELECT CompanyID, CompanyName, CompanyPhone#, CompanyLocation, Area, Street#, EmailAddress FROM CompanyDetail where EmailAddress like '" + SearchCompanyTextBox.Text + "%' ", CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                CONN.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "CompanyName")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                SqlDataAdapter DA = new SqlDataAdapter("SELECT CompanyID, CompanyName, CompanyPhone#, CompanyLocation, Area, Street#, EmailAddress FROM CompanyDetail where CompanyName like'" + SearchCompanyTextBox.Text + "%'", CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                CONN.Close();

            }
            else if (comboBox1.Text == "EmailAddress")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                SqlDataAdapter DA = new SqlDataAdapter("SELECT CompanyID, CompanyName, CompanyPhone#, CompanyLocation, Area, Street#, EmailAddress FROM CompanyDetail where EmailAddress like'" + SearchCompanyTextBox.Text + "%'", CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
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
