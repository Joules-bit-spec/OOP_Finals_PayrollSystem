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

namespace OOP_Finals_PayrollSystem
{
    public partial class SalaryForm : Form
    {
        public SalaryForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {
            // Display employee information
            lblEmpID.Text = CurrentUser.EmployeeID.ToString();
            lblEmpName.Text = CurrentUser.GetFullName();
            lblPos.Text = CurrentUser.Position;
            lblDept.Text = CurrentUser.Department;

            // Display salary and deduction information
            lblBasicSalary.Text = CurrentUser.BasicSalary.ToString("C");
            lblBasSal.Text = CurrentUser.BasicSalary.ToString("C");
            lblTotDeduc.Text = CurrentUser.TotalDeductions.ToString("C");
            lblNetPay.Text = CurrentUser.NetPay.ToString("C");

            // Populate the DataGridView with deduction breakdown
            PopulateDeductionsGrid();
        }

        private void PopulateDeductionsGrid()
        {
            // Clear existing data
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Define columns
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Rate", "Rate / Percent");
            dataGridView1.Columns.Add("Basis", "Basis");
            dataGridView1.Columns.Add("Amount", "Amount");

            // Set column widths
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 200;

            // Add deduction rows
            dataGridView1.Rows.Add("Withholding Tax", "15.00%", CurrentUser.BasicSalary.ToString("C"), CurrentUser.WithholdingTax.ToString("C"));
            dataGridView1.Rows.Add("PhilHealth", "5.00%", CurrentUser.BasicSalary.ToString("C"), CurrentUser.PhilHealth.ToString("C"));
            dataGridView1.Rows.Add("SSS", "15.00%", CurrentUser.BasicSalary.ToString("C"), CurrentUser.SSS.ToString("C"));
            dataGridView1.Rows.Add("Pag-IBIG", "4.00%", CurrentUser.BasicSalary.ToString("C"), CurrentUser.PagIbig.ToString("C"));

            // Add total row
            DataGridViewRow totalRow = new DataGridViewRow();
            totalRow.CreateCells(dataGridView1);
            totalRow.Cells[0].Value = "TOTAL DEDUCTIONS";
            totalRow.Cells[3].Value = CurrentUser.TotalDeductions.ToString("C");
            totalRow.DefaultCellStyle.Font = new Font("DM Sans 14pt", 10, FontStyle.Bold);
            totalRow.DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Rows.Add(totalRow);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
    }
}
