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
    public partial class RegForm : Form
    {
        private readonly Database Db = new Database();

        public RegForm()
        {
            InitializeComponent();
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate all fields before creating employee
                if (string.IsNullOrWhiteSpace(txtRegFname.Text.Trim()) || 
                    string.IsNullOrWhiteSpace(txtRegSname.Text.Trim()) || 
                    string.IsNullOrWhiteSpace(txtRegMidInit.Text.Trim()) || 
                    string.IsNullOrWhiteSpace(cmbRegGender.Text.Trim()) || 
                    string.IsNullOrWhiteSpace(dtpRegBirth.Text.Trim()) || 
                    string.IsNullOrWhiteSpace(txtRegEmail.Text.Trim()) || 
                    string.IsNullOrWhiteSpace(txtRegContact.Text.Trim()) || 
                    string.IsNullOrWhiteSpace(txtRegAddress.Text.Trim()) || 
                    string.IsNullOrWhiteSpace(cmbDept.Text.Trim()) || 
                    string.IsNullOrWhiteSpace(cmbPosition.Text.Trim()) || 
                    string.IsNullOrWhiteSpace(txtRegUserID.Text.Trim()) || 
                    string.IsNullOrWhiteSpace(txtRegPass.Text.Trim()))
                {
                    throw new ArgumentException("All fields must be filled out.");
                }

                Employee employee = new Employee
                {
                    firstName = txtRegFname.Text.Trim(),
                    lastName = txtRegSname.Text.Trim(),
                    middleInit = txtRegMidInit.Text.Trim(),
                    gender = cmbRegGender.Text.Trim(),
                    birthDate = dtpRegBirth.Text.Trim(),
                    email = txtRegEmail.Text.Trim(),
                    contactNo = int.Parse(txtRegContact.Text.Trim()),
                    address = txtRegAddress.Text.Trim(),
                    department = cmbDept.Text.Trim(),
                    position = cmbPosition.Text.Trim(),
                    userID = int.Parse(txtRegUserID.Text.Trim()),
                    passWord = txtRegPass.Text.Trim()
                };

                int newEmployee = Db.RegisterEmployee(employee);
                MessageBox.Show("Employee registered successfully! Employee ID: " + newEmployee, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Validation error: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid format for numeric fields (UserID and Contact Number).", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDept.SelectedItem == "Operations")
            {
                cmbPosition.Items.Clear();
                cmbPosition.Items.Add("Service Technician");
                cmbPosition.Items.Add("Detailer");
                cmbPosition.Items.Add("Inventory Clerk");
                cmbPosition.SelectedIndex = 0;
            }
            else if (cmbDept.SelectedItem == "Sales & Inventory")
            {
                cmbPosition.Items.Clear();
                cmbPosition.Items.Add("Sales Consultant");
                cmbPosition.Items.Add("Finance Specialist");
                cmbPosition.SelectedIndex = 0;
            }
            else if (cmbDept.SelectedItem == "Finance & Administration")
            {
                cmbPosition.Items.Clear();
                cmbPosition.Items.Add("Title Clerk");
                cmbPosition.Items.Add("Bookkeeper");
                cmbPosition.Items.Add("Branch Manager");
                cmbPosition.SelectedIndex = 0;
            }
            else if (cmbDept.SelectedItem == "Customer Service")
            {
                cmbPosition.Items.Clear();
                cmbPosition.Items.Add("Service Advisor");
                cmbPosition.SelectedIndex = 0;
            }
            else
            {
                cmbPosition.Items.Clear();
                MessageBox.Show("Please select a valid department to see available positions.", "Invalid Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }



