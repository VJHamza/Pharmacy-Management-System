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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

   

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            
            if (dataGridView6.DataSource == null)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into SaleMedToCustomer(InvoiceID,CustomerName,Phone#,Date,UserID) values ('"+textBox14.Text+"','" + textBox15.Text + "','" + textBox16.Text + "','" + dateTimePicker3.Value.ToString() + "','" + textBox17.Text + "')";
                cmd.ExecuteNonQuery();
            }
            SqlCommand command;
                command = new SqlCommand("select Quantity from StockTable where MedID='" + textBox19.Text + "'", conn);            
                int Quantity = Convert.ToInt32(command.ExecuteScalar());

                int quantity_enter = Convert.ToInt16(textBox20.Text);
                
                if (Quantity == '0')
                {
                    MessageBox.Show("Stock finished!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command = new SqlCommand("Delete from SaleMedToCustomer where InvoiceID = '" + textBox14.Text + "'", conn);
                    command.ExecuteNonQuery();
                    textBox15.Clear();
                    textBox16.Clear();
                    textBox18.Clear();
                    textBox19.Clear();
                    textBox20.Clear();
                }
                else if (Quantity < quantity_enter)
                {
                    MessageBox.Show("Insufficient Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command = new SqlCommand("Delete from SaleMedToCustomer where InvoiceID = '" + textBox14.Text + "'", conn);
                    command.ExecuteNonQuery();
                    textBox15.Clear();
                    textBox16.Clear();
                    textBox18.Clear();
                    textBox19.Clear();
                    textBox20.Clear();
                }
                else
                {
                    command = new SqlCommand("select RetailUnitPrice from StockTable where MedID='" + textBox19.Text + "'", conn);
                    double price = Convert.ToDouble(command.ExecuteScalar());
                    price = price * Convert.ToDouble(textBox20.Text);
                    textBox21.Text = Convert.ToString(Convert.ToDouble(textBox21.Text) + price);

                    SqlCommand com = new SqlCommand("Insert into RecordTable(InvoiceID,MedName,MedID,Quantity,SalePrice) values('" + textBox14.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + price + "')", conn);
                    com.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT InvoiceID,MedID,MedName,Quantity,SalePrice FROM RecordTable  where  InvoiceID = '" + textBox14.Text + "' ", conn);

                    DataTable dt = new DataTable();

                    dt.Columns.Add("Sr#");
                    dt.Columns["Sr#"].AutoIncrement = true;
                    dt.Columns["Sr#"].AutoIncrementSeed = 1;

                    sda.Fill(dt);
                    dataGridView6.DataSource = dt;
                    conn.Close();
                    textBox18.Clear();
                    textBox19.Clear();
                    textBox20.Clear();
                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            dataGridView6.DataSource = null;
            MessageBox.Show("Sale Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlCommand cmd;
            
            cmd = new SqlCommand("Update  SaleMedToCustomer set TotalAmount='"+textBox21.Text+"' where InvoiceID='"+textBox14.Text+"'", conn);
            cmd.ExecuteNonQuery();
            
            
            //foreach(lis)
            
                
             cmd = new SqlCommand("UPDATE StockTable SET  Quantity = StockTable.Quantity - RecordTable.Quantity FROM  RecordTable INNER JOIN StockTable ON StockTable.MedID = RecordTable.MedID WHERE (StockTable.MedID IN (SELECT  MedID  FROM RecordTable AS RecordTable_1 WHERE (InvoiceID = '"+textBox14.Text+"')))", conn);
            cmd.ExecuteNonQuery();
            
            textBox17.Clear(); textBox15.Clear(); textBox16.Clear();

            GenerateInvoice GI = new GenerateInvoice(textBox14.Text,textBox21.Text);
            GI.Show();

            SqlCommand DA = new SqlCommand("Select count(InvoiceID) from SaleMedToCustomer", conn);
            int count = Convert.ToInt32(DA.ExecuteScalar());
            textBox14.Text = Convert.ToString(count + 1);

            textBox21.Text = Convert.ToString(0);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from RecordTable where InvoiceID = '" + textBox14.Text + "'", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("Delete from SaleMedToCustomer where InvoiceID = '" + textBox14.Text + "'", conn);
            cmd.ExecuteNonQuery();
            dataGridView6.DataSource = null;
            textBox21.Text = "0";
            textBox15.Clear();
            textBox16.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT S1.MedID, S1.MedName, S1.Quantity,  S1.RetailUnitPrice FROM StockTable S1 where MedName like '" + textBox18.Text + "%' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView5.DataSource = dt;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Record_Load_1(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            sql.Open();
            SqlCommand DA = new SqlCommand("Select count(InvoiceID) from SaleMedToCustomer", sql);
            int count = Convert.ToInt32(DA.ExecuteScalar());
            textBox14.Text = Convert.ToString(count + 1);
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffForm sf = new StaffForm();
            sf.Show();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
