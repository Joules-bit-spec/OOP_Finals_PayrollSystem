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
        private readonly RegistrationService registrationService;
        private readonly PositionRepository positionRepository;

        public RegForm()
        {
            InitializeComponent();
            registrationService = new RegistrationService();
            positionRepository = new PositionRepository();
            InitializeForm();
        }

        /// <summary>
        /// Initializes the form with departments.
        /// </summary>
        private void InitializeForm()
        {
            LoadDepartments();
        }

        /// <summary>
        /// Loads all departments into the department combo box.
        /// </summary>
        private void LoadDepartments()
        {
            var departments = registrationService.GetDepartments();
            cmbDept.Items.Clear();
            foreach (var dept in departments)
            {
                cmbDept.Items.Add(dept);
            }
        }

        /// <summary>
        /// Handles department selection change and updates positions.
        /// </summary>
        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePositionsForSelectedDepartment();
        }

        /// <summary>
        /// Updates the positions combo box based on selected department.
        /// </summary>
        private void UpdatePositionsForSelectedDepartment()
        {
            if (cmbDept.SelectedItem == null)
                return;

            string selectedDepartment = cmbDept.SelectedItem.ToString();
            var positions = registrationService.GetPositionsByDepartment(selectedDepartment);

            cmbPosition.Items.Clear();
            foreach (var position in positions)
            {
                cmbPosition.Items.Add(position);
            }
        }

        /// <summary>
        /// Handles the Register button click event.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather input from form
                var input = GatherRegistrationInput();

                // Register employee
                var result = registrationService.RegisterEmployee(input);

                if (result.IsSuccess)
                {
                    MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                    NavigateToLoginForm();
                }
                else
                {
                    MessageBox.Show(result.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gathers input from form controls into a model.
        /// </summary>
        private RegistrationInputModel GatherRegistrationInput()
        {
            return new RegistrationInputModel
            {
                FirstName = txtRegFname.Text.Trim(),
                LastName = txtRegSname.Text.Trim(),
                MiddleInitial = txtRegMidInit.Text.Trim(),
                Gender = cmbRegGender.SelectedItem?.ToString() ?? "",
                Birthday = cmbRegBday.SelectedItem?.ToString() ?? "",
                Email = txtRegEmail.Text.Trim(),
                ContactNumber = txtRegContact.Text.Trim(),
                Address = txtRegAddress.Text.Trim(),
                Department = cmbDept.SelectedItem?.ToString() ?? "",
                Position = cmbPosition.SelectedItem?.ToString() ?? ""
            };
        }

        /// <summary>
        /// Clears all form input fields.
        /// </summary>
        private void ClearFormFields()
        {
            txtRegFname.Clear();
            txtRegSname.Clear();
            txtRegMidInit.Clear();
            txtRegEmail.Clear();
            txtRegContact.Clear();
            txtRegAddress.Clear();
            cmbRegGender.SelectedIndex = -1;
            cmbDept.SelectedIndex = -1;
            cmbPosition.Items.Clear();
        }

        /// <summary>
        /// Handles the Cancel button click event.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigateToLoginForm();
        }

        /// <summary>
        /// Navigates to the login form.
        /// </summary>
        private void NavigateToLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
