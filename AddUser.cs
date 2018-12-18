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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" & textBox2.Text.Trim() != "" & textBox3.Text.Trim() != "" & textBox4.Text.Trim() != "" & textBox5.Text.Trim() != "" & textBox6.Text.Trim() != "" & textBox7.Text.Trim() != "" & textBox8.Text.Trim() != "" & textBox9.Text.Trim() != "")
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                Conn.Open();
                MessageBox.Show("Conn OPen");
                string Query = "Insert into UserTable ( UserName, FatherName, CNIC, AddressLocation, House#, Street#, City, Phone#, Role, HireDate) values ('"+ textBox1.Text +"','" +textBox2.Text+"','"+ textBox3.Text +"','"+ textBox4.Text +"','" +textBox5.Text+"','"+ textBox6.Text +"','"+ textBox7.Text +"','" +textBox8.Text+"','"+ textBox9.Text +"','"+dateTimePicker1.Value.ToString()+"')";
                SqlCommand Command = new SqlCommand(Query, Conn);
                Command.ExecuteNonQuery();
                display_data();
                MessageBox.Show("Staff Data Inserted!");
                Conn.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
            }
            else
            {
                MessageBox.Show("Enter Complete Entries");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm AD = new AdminForm();
            AD.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        public void display_data()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            Conn.Open();
            MessageBox.Show("Conn OPen");
            string Query = "Select * from UserTable";
            SqlCommand Command = new SqlCommand(Query, Conn);
            Command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display_data();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
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
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
    }
}
