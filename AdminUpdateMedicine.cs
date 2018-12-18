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
    public partial class AdminUpdateMedicine : Form
    {
        public AdminUpdateMedicine()
        {
            InitializeComponent();
        }
        public void FormLOAD()
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
            textBox1.Clear(); textBox5.Clear(); textBox3.Clear(); textBox3.Clear(); textBox4.Clear();
            textBox10.Clear(); textBox9.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox2.Clear();
            FormLOAD();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("Select * from StockTable", conn);
            DataTable DATA = new DataTable();
            SDA.Fill(DATA);
            dataGridView1.DataSource = DATA;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm AF = new AdminForm();
            AF.Show();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            //conn.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT S1.SupplierID, S1.MedName, S1.MedGenericName, S1.MedCompany, S1.MedCatagory, S1.Quantity, S1.RetailPrice, S1.RetailUnitPrice  FROM StockTable S1,StockMFG_EXP_DATE S2 where (S1.Medname like '" + textBox2.Text + "%' AND (S1.MedID=S2.MedID) ", conn);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //conn.Close();
        }
    }
}
