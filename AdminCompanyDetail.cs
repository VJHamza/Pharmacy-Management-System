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
using System.Text.RegularExpressions;
namespace Pharmacy
{
    public partial class AdminCompanyDetail : Form
    {
        public AdminCompanyDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                Connection.Open();
                //MessageBox.Show("Connection Open");
                Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?
                                ^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+
                                [a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

                if (emailRegex.IsMatch(textBox6.Text))
                {
                    MessageBox.Show(textBox6.Text + "matches the expected format.", "Attention");
                    String query = "Insert into CompanyDetail(CompanyName,CompanyPhone#,CompanyLocation,Area,Street#,EmailAddress,Date) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Value.ToString() + "')";
                    SqlCommand Command = new SqlCommand(query, Connection);
                    Command.ExecuteNonQuery();
                    display_data();
                    MessageBox.Show("CompanyInformation Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connection.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
                else
                {
                    MessageBox.Show(textBox6.Text + " does'nt matches the expected format.", "Attention");
 
                }
            }
            else
            {
                MessageBox.Show("Incomplete Entries!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm AF = new AdminForm();
            AF.Show();
        }
        public void display_data()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            Conn.Open();
            string Query = "Select * from CompanyDetail";
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
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
        }
    }
}
