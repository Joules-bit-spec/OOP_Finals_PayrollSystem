using System;
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
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // Display user information
            lblUser.Text = CurrentUser.GetFullName();
            lblPosition.Text = CurrentUser.Position;

            // Display payroll summary information
            txtUserName.Text = CurrentUser.EmployeeID.ToString();
            textBox1.Text = CurrentUser.GetFullName();
            textBox2.Text = CurrentUser.Position;
            textBox3.Text = CurrentUser.Department;
            textBox7.Text = CurrentUser.BasicSalary.ToString("C");
            textBox6.Text = CurrentUser.TotalDeductions.ToString("C");
            textBox5.Text = CurrentUser.NetPay.ToString("C");
        }
    }
}