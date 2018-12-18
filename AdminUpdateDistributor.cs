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
    public partial class AdminUpdateDistributor : Form
    {
        public AdminUpdateDistributor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            //textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("Update SupplierDetail set CompanyID='" + textBox1.Text + "',DistributorName ='" + textBox2.Text + "', DistributorPhone# ='" + textBox3.Text + "',SupplyDay='" + textBox4.Text + "'where DistributorID = '" + textBox5.Text + "'", conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("Select SupplierDetail.DistributorID, SupplierDetail.CompanyID,SupplierDetail.DistributorName, SupplierDetail.DistributorPhone#, SupplierDetail.SupplyDay, CompanyDetail.CompanyName from SupplierDetail,CompanyDetail where SupplierDetail.CompanyID=CompanyDetail.CompanyID", conn);
            DataTable DATA = new DataTable();
            SDA.Fill(DATA);
            dataGridView1.DataSource = DATA;
            conn.Close();
        }
    }
}
