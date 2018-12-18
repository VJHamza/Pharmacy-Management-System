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
    public partial class AdminUpdateCompany : Form
    {
        public AdminUpdateCompany()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("Update CompanyDetail set CompanyName='" + textBox1.Text + "',CompanyPhone#='" + textBox2.Text + "',CompanyLocation='" + textBox3.Text + "',Area='" + textBox4.Text + "',Street#='" + textBox5.Text + "',EmailAddress='" + textBox6.Text + "' where CompanyID = '"+textBox7.Text+"'", conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("Select * from CompanyDetail", conn);
            DataTable DATA = new DataTable();
            SDA.Fill(DATA);
            dataGridView1.DataSource = DATA;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm AF = new AdminForm();
            AF.Show();
        }
    }
}