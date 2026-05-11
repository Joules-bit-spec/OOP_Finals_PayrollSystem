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
    public partial class ProfileEdit : Form
    {
        private ProfileForm parentForm;
        public ProfileEdit(ProfileForm profileForm)
        {
            InitializeComponent();
            parentForm = profileForm;
            LoadUserInfo();
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE Employees SET 
                                FirstName = @FirstName, 
                                LastName = @LastName, 
                                MiddleInitial = @MiddleInitial,
                                ContactNo = @ContactNo,
                                Email = @Email, 
                                WHERE EmployeeID = @EmployeeID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtEditFname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtEditSname.Text);
                cmd.Parameters.AddWithValue("@MiddleInitial", txtEditMidInit.Text);
                cmd.Parameters.AddWithValue("@ContactNo", txtEditContactNo.Text);
                cmd.Parameters.AddWithValue("@Email", txtEditEmail.Text);
                cmd.Parameters.AddWithValue("@EmployeeID", CurrentUser.EmployeeID);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CurrentUser.FirstName = txtEditFname.Text;
            CurrentUser.LastName = txtEditSname.Text;
            CurrentUser.MiddleInit = txtEditMidInit.Text;

            parentForm.LoadUserInfo();
            parentForm.Show();
            this.Hide();
        }

        private void ProfileEdit_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Employees WHERE EmployeeID = @EmployeeID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", CurrentUser.EmployeeID);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtEditFname.Text = dr["FirstName"].ToString();
                    txtEditSname.Text = dr["LastName"].ToString();
                    txtEditMidInit.Text = dr["MiddleInitial"].ToString();

                    dtpEditBirth.Value = Convert.ToDateTime(dr["Birthdate"]);
                    dtpEditBirth.Format = DateTimePickerFormat.Custom;
                    dtpEditBirth.CustomFormat = "MMM dd, yyyy";
                    cmbEditGender.SelectedItem = dr["Gender"].ToString();

                    txtEditContactNo.Text = dr["ContactNo"].ToString();
                    txtEditEmail.Text = dr["Email"].ToString();
                    txtEditAddress.Text = dr["Address"].ToString();

                    txtEditUserID.Text = dr["UserID"].ToString();
                    txtEditPass.Text = dr["Password"].ToString();

                    lblUser.Text = $"{dr["FirstName"]} {dr["MiddleInitial"]} {dr["LastName"]}".ToString();
                    lblPosition.Text = dr["Position"].ToString();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Hide();
        }
    }
}
