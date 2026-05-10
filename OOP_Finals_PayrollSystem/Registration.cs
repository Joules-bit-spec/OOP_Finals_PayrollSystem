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


            
            try
            {
                int newEmployee = Db.RegisterEmployee(employee);
                MessageBox.Show("Employee registered successfully! Employee ID: " + newEmployee, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

                if(string.IsNullOrEmpty(Employee.firstName) || string.IsNullOrEmpty(Employee.lastName) || string.IsNullOrEmpty(Employee.middleInit) || string.IsNullOrEmpty(Employee.gender) || string.IsNullOrEmpty(Employee.birthDate) || string.IsNullOrEmpty(Employee.email) || string.IsNullOrEmpty(Employee.contactNo.ToString()) || string.IsNullOrEmpty(Employee.address) || string.IsNullOrEmpty(Employee.department) || string.IsNullOrEmpty(Employee.position) || string.IsNullOrEmpty(Employee.userID.ToString()) || string.IsNullOrEmpty(Employee.passWord))
                {
                    throw new ArgumentNullException("All fields must be filled out.");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Validation error: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        }
    }



