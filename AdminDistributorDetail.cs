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
    public partial class AdminDistributorDetail : Form
    {
        public AdminDistributorDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                Connection.Open();
               // MessageBox.Show("Connection Open");
                String query = "INSERT INTO SupplierDetail (CompanyID, DistributorName, DistributorPhone#, SupplyDay,Date) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value.ToString() + "')";
                SqlCommand Command = new SqlCommand(query, Connection);
                Command.ExecuteNonQuery();
                display_data();
                MessageBox.Show("Distributor Added!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Connection.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Incomplete Entries!");
            }
        }
        public void display_data()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            Conn.Open();
            string Query = "Select * from SupplierDetail";
            SqlCommand Command = new SqlCommand(Query, Conn);
            Command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm AF=new AdminForm();
            AF.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
