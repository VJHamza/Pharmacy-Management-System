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
    public partial class AdminUpdateUser : Form
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");

        public AdminUpdateUser()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void DisplayData()
        {
            Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from UserTable ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE UserTable SET UserName ='" + textBox1.Text + "', FatherName ='" + textBox2.Text + "', CNIC ='" + textBox3.Text + "', AddressLocation ='" + textBox4.Text + "', House# ='" + textBox5.Text + "', Street# ='" + textBox6.Text + "', City ='" + textBox7.Text + "', Phone# ='" + textBox8.Text + "', Role ='" + textBox9.Text + "' where UserID = '"+textBox10.Text+"' ";
            cmd.ExecuteNonQuery();

            Conn.Close();
            DisplayData();
            textBox1.Clear();
            textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
            textBox9.Clear(); textBox8.Clear(); textBox7.Clear(); textBox6.Clear();
            textBox10.Clear();

            MessageBox.Show("Record Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm AF = new AdminForm();
            AF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }
    }
}
