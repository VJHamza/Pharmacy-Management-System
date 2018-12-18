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
    public partial class StockInchargeUpdateMedicine : Form
    {
        public StockInchargeUpdateMedicine()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("Select * from StockTable", conn);
            DataTable DATA = new DataTable();
            SDA.Fill(DATA);
            dataGridView1.DataSource = DATA;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("UPDATE StockTable SET  MedName ='" + textBox2.Text + "', MedGenericName ='" + textBox3.Text + "', MedCompany ='" + textBox11.Text + "', MedCatagory ='" + textBox9.Text + "', RetailPrice ='" + textBox4.Text + "', RetailUnitPrice ='" + textBox12.Text + "', Quantity ='" + textBox10.Text + "', SupplierID ='" + textBox1.Text + "'  where MedID = '" + textBox5.Text + "'", conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("REcord Updated");
        
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StockIncharge SI = new StockIncharge();
            SI.Show();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
