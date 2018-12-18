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
    public partial class AdminSearchDistributor : Form
    {
        public AdminSearchDistributor()
        {
            InitializeComponent();
        }

        private void SearchMedTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT S1.DistributorID, S1.CompanyID,C1.CompanyName, S1.DistributorName, S1.DistributorPhone#, S1.SupplyDay, S1.Date FROM SupplierDetail S1,CompanyDetail C1 where S1.CompanyID=C1.CompanyID AND DistributorName like '" + SearchMedTextBox.Text + "%' Order By DistributorID", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm Af = new AdminForm();
            Af.Show();
        }
    }
}
