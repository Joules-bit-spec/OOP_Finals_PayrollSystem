using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Finals_PayrollSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
        }

        private void btnDeductions_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryForm deductionsForm = new SalaryForm();
            deductionsForm.Show();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            PayrollForm payrollForm = new PayrollForm();
            payrollForm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?","Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryForm deductionForm = new SalaryForm();
            deductionForm.Show();
        }
    }
}
