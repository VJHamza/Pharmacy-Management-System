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
    public partial class ExpiryAdmin : Form
    {
        public ExpiryAdmin()
        {
            InitializeComponent();
        }
        public void display_data()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            Conn.Open();
            string Query = "Select * from StockMFG_EXP_DATE";
            SqlCommand Command = new SqlCommand(Query, Conn);
            Command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                connection.Open();
                //MessageBox.Show("Connection open");

                String query = "INSERT INTO StockMFG_EXP_DATE (MedID, MfgDate, ExpDate, TradePrice, Date) values ('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Value.ToString() + "')";
                SqlCommand Command = new SqlCommand(query, connection);

                Command.ExecuteNonQuery();
                display_data();
                MessageBox.Show("Medicine added successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Enter Complete Entries. Thank You.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AddMedicineForm AMF = new AddMedicineForm();
            AMF.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT S1.MedID, S1.MedName, S1.MedGenericName, S1.MedCompany, S1.MedCatagory, S1.Quantity,S2.MfgDate, S2.ExpDate, S2.TradePrice, S1.RetailPrice, S1.RetailUnitPrice, S1.Date, S1.SupplierID FROM StockTable S1,StockMFG_EXP_DATE S2 where MedName like '" + textBox2.Text + "%' AND S1.MedID=S2.MedID Order By MedID", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
