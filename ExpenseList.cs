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
    public partial class ExpenseList : Form
    {
        public ExpenseList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into ExpenseTable(Expense_Detail,Amount,Date) values ('" + textBox1.Text + "','" + textBox2.Text + "', '" + dateTimePicker1.Value.ToString()+ "' )", conn);
                cmd.ExecuteNonQuery();

                display_data();

                cmd = new SqlCommand("select sum(Amount) From ExpenseTable where DAte='" + dateTimePicker1.Value.ToString() + "' ", conn);
                int amount = Convert.ToInt16(cmd.ExecuteScalar());
                textBox3.Text = Convert.ToString(Convert.ToInt16(textBox3.Text) + amount);

                textBox1.Clear();
                textBox2.Clear();
                conn.Close();
            }
            else 
            {
                MessageBox.Show("Enter Complete Entries. Thank You.");

            }
        }

        public void display_data()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            
            Conn.Open();
            
//            MessageBox.Show("Conn OPen");
            
            string Query = "SELECT Serial_No AS ID, Expense_Detail AS [Expense Detail], Amount AS [Amount in Rs.], Date AS [Expense Date] FROM ExpenseTable";

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
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();

            SqlCommand comand = new SqlCommand("select sum(Amount) From ExpenseTable where DAte='" + dateTimePicker1.Value.ToString() + "' ", conn);
            int amount = Convert.ToInt16(comand.ExecuteScalar());
            textBox3.Text = Convert.ToString(Convert.ToInt16(textBox3.Text) + amount);

            conn.Close();
        }
    }
}
