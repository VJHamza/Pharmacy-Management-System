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
    public partial class SearchMedicine : Form
    {

        public SearchMedicine()
        {
            InitializeComponent();
        }

        private void SearchMedOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchMedOptionComboBox.Text == "MedName")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT S1.MedID, S1.MedName, S1.MedGenericName, S1.MedCompany, S1.MedCatagory, S1.Quantity,S2.MfgDate, S2.ExpDate, S2.TradePrice, S1.RetailPrice, S1.RetailUnitPrice, S1.Date, S1.SupplierID FROM StockTable S1,StockMFG_EXP_DATE S2 where MedName like '" + MedicineNameBox.Text + "%' AND S1.MedID=S2.MedID ", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (SearchMedOptionComboBox.Text == "MedGenericName")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT S1.MedID, S1.MedName, S1.MedGenericName, S1.MedCompany, S1.MedCatagory, S1.Quantity,S2.MfgDate, S2.ExpDate, S2.TradePrice, S1.RetailPrice, S1.RetailUnitPrice, S1.Date, S1.SupplierID FROM StockTable S1,StockMFG_EXP_DATE S2 where MedName like '" + MedicineNameBox.Text + "%' AND S1.MedID=S2.MedID ", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (SearchMedOptionComboBox.Text == "MedCatagory")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT S1.MedID, S1.MedName, S1.MedGenericName, S1.MedCompany, S1.MedCatagory, S1.Quantity,S2.MfgDate, S2.ExpDate, S2.TradePrice, S1.RetailPrice, S1.RetailUnitPrice, S1.Date, S1.SupplierID FROM StockTable S1,StockMFG_EXP_DATE S2 where MedName like '" + MedicineNameBox.Text + "%' AND S1.MedID=S2.MedID ", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void MedicineNameBox_TextChanged(object sender, EventArgs e)
        {
            if(SearchMedOptionComboBox.Text=="MedName")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT S1.MedID, S1.MedName, S1.MedGenericName, S1.MedCompany, S1.MedCatagory, S1.Quantity,S2.MfgDate, S2.ExpDate, S2.TradePrice, S1.RetailPrice, S1.RetailUnitPrice, S1.Date, S1.SupplierID FROM StockTable S1,StockMFG_EXP_DATE S2 where MedName like '" + MedicineNameBox.Text + "%' AND S1.MedID=S2.MedID ", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(SearchMedOptionComboBox.Text=="MedGenericName")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT S1.MedID, S1.MedName, S1.MedGenericName, S1.MedCompany, S1.MedCatagory, S1.Quantity,S2.MfgDate, S2.ExpDate, S2.TradePrice, S1.RetailPrice, S1.RetailUnitPrice, S1.Date, S1.SupplierID FROM StockTable S1,StockMFG_EXP_DATE S2 where MedGenericName like '" + MedicineNameBox.Text + "%' AND S1.MedID=S2.MedID ", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(SearchMedOptionComboBox.Text=="MedCatagory")
            {
                 SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-24KK9O8\SQLEXPRESS;Initial Catalog=PharmacyDatabase;Persist Security Info=True;User ID=sa;Password=iluvumerijan");
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT S1.MedID, S1.MedName, S1.MedGenericName, S1.MedCompany, S1.MedCatagory, S1.Quantity,S2.MfgDate, S2.ExpDate, S2.TradePrice, S1.RetailPrice, S1.RetailUnitPrice, S1.Date, S1.SupplierID FROM StockTable S1,StockMFG_EXP_DATE S2 where MedCatagory like '" + MedicineNameBox.Text + "%' AND S1.MedID=S2.MedID ", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm SF = new StaffForm();
            SF.Show();
        }
    }
}
