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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void FORM2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchMedicine FM = new SearchMedicine();
            FM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm fm = new LoginForm();
            fm.Show();

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchCompany SC = new SearchCompany();
            SC.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Record S = new Record();
            S.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            SerachCustomer sc = new SerachCustomer();
            sc.Show();
        }
    }
}
