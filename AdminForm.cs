using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm FOM = new LoginForm();
            FOM.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            AddMedicineForm AMF = new AddMedicineForm();
            AMF.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminSearchMedicine SM = new AdminSearchMedicine();
            SM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser AU = new AddUser();
            AU.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminSearchStaff ASS = new AdminSearchStaff();
            ASS.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminCompanyDetail ACD = new AdminCompanyDetail();
            ACD.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminSearchCompany ASC= new AdminSearchCompany();
            ASC.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDistributorDetail ASD = new AdminDistributorDetail();
            ASD.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminSearchDistributor ASS = new AdminSearchDistributor();
            ASS.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminUpdateMedicine SMUM = new AdminUpdateMedicine();
            SMUM.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminUpdateUser AUU = new AdminUpdateUser();
            AUU.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminUpdateCompany AUC = new AdminUpdateCompany();
            AUC.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminUpdateDistributor AUS = new AdminUpdateDistributor();
            AUS.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
            ExpiryReport ER = new ExpiryReport();
            ER.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            SaleReport gi = new SaleReport();
            gi.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            MedicineShortage MS = new MedicineShortage();
            MS.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ExpenseList MS = new ExpenseList();
            MS.Show();
        }
    }
}
