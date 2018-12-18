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
    public partial class AdminSearchStaff : Form
    {
        public AdminSearchStaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "UserID")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                string Query = "SELECT   UserID, UserName, FatherName, CNIC, AddressLocation, House#, Street#, City, Phone#, Role, HireDate FROM UserTable where UserID like '" + textBox1.Text + "%' Order By UserID";
                SqlDataAdapter DA = new SqlDataAdapter(Query, CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                CONN.Close();
            }
            else if (comboBox1.Text == "UserName")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                SqlDataAdapter DA = new SqlDataAdapter("SELECT UserName, UserID, FatherName, CNIC, AddressLocation, House#, Street#, City, Phone#, Role, HireDate FROM UserTable where UserName like '" + textBox1.Text + "%' Order By UserID", CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                CONN.Close();
            }
            else if (comboBox1.Text == "CNIC")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                SqlDataAdapter DA = new SqlDataAdapter("SELECT CNIC, UserID, UserName, FatherName, House#, Street#, AddressLocation, City, Phone#, Role, HireDate FROM UserTable where CNIC like'" + textBox1.Text + "%' Order By UserID", CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                CONN.Close();

            }
            else if (comboBox1.Text == "Role")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                SqlDataAdapter DA = new SqlDataAdapter("SELECT Role, UserName, FatherName, CNIC, AddressLocation, House#, Street#, City, Phone#, HireDate, UserID FROM UserTable where ROle like'" + textBox1.Text + "%' Order By UserID", CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                CONN.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "UserID")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                string Query = "SELECT   UserID, UserName, FatherName, CNIC, AddressLocation, House#, Street#, City, Phone#, Role, HireDate FROM UserTable where UserID like '"+textBox1.Text+"%' Order By UserID";
                SqlDataAdapter DA = new SqlDataAdapter(Query, CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                CONN.Close();
            }
            else if (comboBox1.Text == "UserName")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                SqlDataAdapter DA = new SqlDataAdapter("SELECT UserName, UserID, FatherName, CNIC, AddressLocation, House#, Street#, City, Phone#, Role, HireDate FROM UserTable where UserName like '" + textBox1.Text + "%' Order By UserID", CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                CONN.Close();
            }
            else if (comboBox1.Text == "CNIC")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                SqlDataAdapter DA = new SqlDataAdapter("SELECT CNIC, UserID, UserName, FatherName, House#, Street#, AddressLocation, City, Phone#, Role, HireDate FROM UserTable where CNIC like'" + textBox1.Text + "%' Order By UserID", CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                CONN.Close();
 
            }
            else if (comboBox1.Text == "Role")
            {
                SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                CONN.Open();
                //MessageBox.Show("Conn open");
                SqlDataAdapter DA = new SqlDataAdapter("SELECT Role, UserName, FatherName, CNIC, AddressLocation, House#, Street#, City, Phone#, HireDate, UserID FROM UserTable where ROle like'" + textBox1.Text + "%' Order By UserID", CONN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                CONN.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm AF = new AdminForm();
            AF.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
