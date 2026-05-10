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
    public partial class LoginForm : Form
    {
        private readonly DB database = new DB();
        public LoginForm()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();

            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter your Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = DB.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Employees WHERE UserID = @UserID AND Password = @Password";
                    using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", txtUserID.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            HomeForm homepage = new HomeForm();
                            homepage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid UserID or Password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
