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
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values from form
                double hoursPerDay = string.IsNullOrWhiteSpace(txtHourDay.Text) ? 0 : double.Parse(txtHourDay.Text);
                double daysWorked = string.IsNullOrWhiteSpace(txtNoDays.Text) ? 0 : double.Parse(txtNoDays.Text);

                Position staff = new Position();
                staff.Position = CurrentUser.Position;
                staff.GrossPay = staff.GetPositionRate(); // This gets the hourly rate
                staff.hoursWorked = hoursPerDay;
                staff.daysWorked = daysWorked;

                // Calculate BasicSalary = hourly rate * hours per day * days worked
                double basicSalary = staff.GetBasicSalary();

                // Save values to CurrentUser for persistence
                CurrentUser.HourlyRate = staff.GrossPay;
                CurrentUser.BasicSalary = basicSalary;
                CurrentUser.WithholdingTax = staff.GetTax();
                CurrentUser.PhilHealth = staff.GetPhilhealth();
                CurrentUser.SSS = staff.GetSSS();
                CurrentUser.PagIbig = staff.GetPagibig();
                CurrentUser.TotalDeductions = staff.GetDeduction();
                CurrentUser.NetPay = staff.GetNetPay();

                txtRate.Text = staff.GrossPay.ToString("C");
                txtBasicSal1.Text = basicSalary.ToString("C");
                txtBasicSal2.Text = basicSalary.ToString("C");

                txtPagIbig.Text = staff.GetPagibig().ToString("C");
                txtTax.Text = staff.GetTax().ToString("C");
                txtSSS.Text = staff.GetSSS().ToString("C");
                txtPhilHealth.Text = staff.GetPhilhealth().ToString("C");

                txtTotDeduc1.Text = staff.GetDeduction().ToString("C");
                txtTotDeduc2.Text = staff.GetDeduction().ToString("C");
                txtNetPay.Text = staff.GetNetPay().ToString("C");

                lblWT.Text = staff.GetTax().ToString("C");
                lblPH.Text = staff.GetPhilhealth().ToString("C");
                lblSSS.Text = staff.GetSSS().ToString("C");
                lblPI.Text = staff.GetPagibig().ToString("C");
                lblTotDeduc.Text = staff.GetDeduction().ToString("C");

                MessageBox.Show("Payroll computed and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for hours and days worked.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during calculation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm();
            home.Show();
        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            Position staff = new Position();
            staff.Position = CurrentUser.Position;
            txtRate.Text = staff.GetPositionRate().ToString("C");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
                txtBasicSal1.Clear();
                txtBasicSal2.Clear();
                txtHourDay.Clear();
                txtNoDays.Clear();
                txtNetPay.Clear();
                txtPagIbig.Clear();
                txtPhilHealth.Clear();
                txtTax.Clear();
                txtSSS.Clear();
                txtTotDeduc1.Clear();
                txtTotDeduc2.Clear();
                lblPH.Text = string.Empty;
                lblSSS.Text = string.Empty;
                lblPI.Text = string.Empty;
                lblTotDeduc.Text = string.Empty;
                lblWT.Text = string.Empty;

            }
        }
    }

