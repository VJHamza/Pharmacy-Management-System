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
    public partial class MedicineShortage : Form
    {
        public MedicineShortage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MedicineShortage_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
            sql.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MedID, MedName, MedGenericName, MedCompany, MedCatagory, Quantity, Date FROM StockTable WHERE (Quantity < 20)", sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            AdminForm af = new AdminForm();
            af.Show();
        }
    }
}
