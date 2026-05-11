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
    public partial class LoginForm : Form
    {
        private readonly Database Db = new Database();
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
            try
            {
                // Query Employees table (where registration data is stored), not Users table
                string query = "SELECT * FROM Employees WHERE UserID = @UserID AND Password = @Password";
                var parameters = new Dictionary<string, object>
                {
                    { "@UserID", txtUserID.Text.Trim() },
                    { "@Password", txtPassword.Text.Trim() }
                };
                DataTable result = Db.ExecuteQuery(query, parameters);
                if (result.Rows.Count > 0)
                {
                    // Store current user info
                    CurrentUser.EmployeeID = Convert.ToInt32(result.Rows[0]["EmployeeID"]);
                    CurrentUser.FirstName = result.Rows[0]["FirstName"].ToString();
                    CurrentUser.LastName = result.Rows[0]["LastName"].ToString();
                    CurrentUser.MiddleInit = result.Rows[0]["MiddleInitial"].ToString();
                    CurrentUser.Position = result.Rows[0]["Position"].ToString();
                    CurrentUser.Department = result.Rows[0]["Department"].ToString();

                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomeForm home = new HomeForm();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid UserID or Password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (string.IsNullOrEmpty(txtUserID.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    throw new ArgumentException("All fields are required. Please fill in both UserID and Password.");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Validation error: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                txtUserID.Clear();
                txtPassword.Clear();
            }
        }
    }
}
