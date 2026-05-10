using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Finals_PayrollSystem
{
    public static class DB
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\PayrollSystem.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static int SaveEmployee(Employee employee)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO Employees (FirstName, LastName, MiddleInitial, Gender, Birthday, Email, ContactNumber, Address, Department, Position) VALUES (@FirstName, @LastName, @MiddleInitial, @Gender, @Birthday, @Email, @ContactNumber, @Address, @Department, @Position)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", employee.GetFirstName());
                    command.Parameters.AddWithValue("@LastName", employee.GetLastName());
                    command.Parameters.AddWithValue("@MiddleInitial", employee.GetMiddleInitial());
                    command.Parameters.AddWithValue("@Gender", employee.GetGender());
                    command.Parameters.AddWithValue("@Birthday", employee.GetBirthday());
                    command.Parameters.AddWithValue("@Email", employee.GetEmail());
                    command.Parameters.AddWithValue("@ContactNumber", employee.GetContactNumber());
                    command.Parameters.AddWithValue("@Address", employee.GetAddress());
                    command.Parameters.AddWithValue("@Department", employee.GetDepartment());
                    command.Parameters.AddWithValue("@Position", employee.GetPosition());

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected;
                }
            }
        }
    }
}
