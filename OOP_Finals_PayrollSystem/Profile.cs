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
    public partial class ProfileForm : Form
    {
        private readonly Database Db = new Database();
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileEdit editProfileForm = new ProfileEdit(this);
            editProfileForm.Show();
        }

        private void dtpProBirth_ValueChanged(object sender, EventArgs e)
        {
            dtpProBirth.Format = DateTimePickerFormat.Custom;
            dtpProBirth.CustomFormat = "MM/dd/yyyy";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        public void LoadUserInfo()
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
                    // Populate form controls with user data
                    txtProFname.Text = dr["FirstName"].ToString();
                    txtProSname.Text = dr["LastName"].ToString();
                    txtProMidInit.Text = dr["MiddleInitial"].ToString();

                    dtpProBirth.Value = Convert.ToDateTime(dr["Birthdate"]);
                    dtpProBirth.Format = DateTimePickerFormat.Custom;
                    dtpProBirth.CustomFormat = "MMM dd, yyyy";
                    cmbProGender.SelectedItem = dr["Gender"].ToString();

                    txtProContactNo.Text = dr["ContactNo"].ToString();
                    txtProEmail.Text = dr["Email"].ToString();
                    txtProAddress.Text = dr["Address"].ToString();

                    txtProUserID.Text = dr["UserID"].ToString();
                    txtProPass.Text = dr["Password"].ToString();

                    lblUser.Text = $"{dr["FirstName"]} {dr["MiddleInitial"]} {dr["LastName"]}".ToString();
                    lblPosition.Text = dr["Position"].ToString();
                }
            }
        }
    }
}

