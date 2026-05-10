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
            Position staff = new Position();
            staff.GrossPay = staff.GetPositionRate();
            txtRate.Text = staff.GrossPay.ToString("C");

            txtRate.Text = staff.GetPositionRate().ToString("C");
            txtPagIbig.Text = staff.GetPagibig().ToString("C");
            txtTax.Text = staff.GetTax().ToString("C");
            txtTotDeduc1.Text = staff.GetDeduction().ToString("C");
            txtTotDeduc2.Text = staff.GetDeduction().ToString("C");
            txtNetPay.Text = staff.GetNetPay().ToString("C");
            txtPhilHealth.Text = staff.GetPhilhealth().ToString("C");
            txtBasicSal1.Text = staff.GetBasicSalary().ToString("C");
            lblWT.Text = staff.GetTax().ToString("C");
            lblPH.Text = staff.GetPhilhealth().ToString("C");
            lblSSS.Text = staff.GetSSS().ToString("C");
            lblPI.Text = staff.GetPagibig().ToString("C");
            lblTotDeduc.Text = staff.GetDeduction().ToString("C");
        }
    }
}
