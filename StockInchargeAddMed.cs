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
    public partial class StockInchargeAddMed : Form
    {
        public StockInchargeAddMed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" & textBox2.Text.Trim() != "" & textBox3.Text.Trim() != "" & textBox4.Text.Trim() != "" & textBox9.Text.Trim() != "" & textBox10.Text.Trim() != "" & textBox11.Text.Trim() != "" & textBox12.Text.Trim() != "")
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                connection.Open();
               // MessageBox.Show("Connection open");
                String query = "Insert into StockTable (MedName, MedGenericName, MedCatagory, MedCompany,Quantity,RetailPrice,RetailUnitPrice,SupplierID,Date) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox11.Text + "','" + textBox4.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox12.Text + "','" + dateTimePicker1.Value.ToString() + "')";
                SqlCommand Command = new SqlCommand(query, connection);
                Command.ExecuteNonQuery();
                display_data();
                MessageBox.Show("Medicine added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter Complete Entries", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockIncharge SI = new StockIncharge();
            SI.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expiry EF = new Expiry();
            EF.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display_data();
        }
        public void display_data()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            Conn.Open();
            string Query = "Select * from StockTable";
            SqlCommand Command = new SqlCommand(Query, Conn);
            Command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Conn.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void StockInchargeAddMed_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
