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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PaswordText.PasswordChar = '*';
            PaswordText.MaxLength = 10;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            String query = "select Role from UserTable where UserID =( select UserId from LoginTable where UserName='" + USerText.Text + "'and Password='" + PaswordText.Text.ToString() + "')";
                SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            //sda.Fill(dt);
            if (reader.HasRows == true)
            {
                reader.Read();
                if (int.Parse(reader["Role"].ToString()) == 1)
                {
                    this.Hide();
                    StaffForm fm = new StaffForm();
                    MessageBox.Show("Staff");
                    fm.Show();
                    conn.Close();
                }
                else if (int.Parse(reader["Role"].ToString()) == 2)
                {
                    this.Hide();
                    AdminForm fm = new AdminForm();
                    MessageBox.Show("Admin");
                    fm.Show();
                    conn.Close();
                }
                else if (int.Parse(reader["Role"].ToString()) == 3)
                {
                    this.Hide();
                    StockIncharge SI = new StockIncharge();
                    MessageBox.Show("Stock");
                    SI.Show();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Check ur username and password");
                }
            }
            else
            {
                MessageBox.Show("Invalid username and password","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Enter(object sender, EventArgs e)
        {

        }
    }
}
