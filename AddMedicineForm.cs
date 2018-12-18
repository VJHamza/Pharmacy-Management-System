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
    public partial class AddMedicineForm : Form
    {
        
        public AddMedicineForm()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" & textBox2.Text.Trim() != "" & textBox3.Text.Trim() != "" & textBox4.Text.Trim() != ""  & textBox9.Text.Trim() != "" & textBox10.Text.Trim() != "" & textBox11.Text.Trim() != "" & textBox12.Text.Trim() != "")
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                connection.Open();
                //MessageBox.Show("Connection open");
                textBox5.Text = ((Convert.ToDouble(textBox9.Text)) / (Convert.ToDouble(textBox10.Text))).ToString();                   
                
                String query = "Insert into StockTable (MedName, MedGenericName, MedCatagory, MedCompany,Quantity,RetailPrice,MedicinePacking,UnitPrice,SupplierID,Date) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox11.Text + "','" + textBox4.Text + "','" + textBox9.Text + "','"+textBox10.Text+"','" + textBox5.Text + "','" + textBox12.Text + "','" + dateTimePicker1.Value.ToString() + "')";
                SqlCommand Command = new SqlCommand(query, connection);

                Command.ExecuteNonQuery();
                display_data();
                MessageBox.Show("Medicine added successfully");
                connection.Close();
                textBox1.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox9.Clear();
                textBox5.Clear();
            }
            else
            {
                MessageBox.Show("Enter Complete Entries. Thank You.");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddMedicineForm_Load(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm AF = new AdminForm();
            AF.Show();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpiryAdmin EF = new ExpiryAdmin();
            EF.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox9.Clear();
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
