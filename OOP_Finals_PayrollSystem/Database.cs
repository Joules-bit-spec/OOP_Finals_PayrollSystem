using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OOP_Finals_PayrollSystem
{
    public class Database
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_DB;Integrated Security=True";

        public int RegisterEmployee(Employee employee)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert the employee and retrieve the EmployeeID
                    // Using PascalCase column names to match SQL Server schema
                    var command = new SqlCommand(
                        "INSERT INTO Employees (UserID, Password, FirstName, LastName, MiddleInitial, Gender, Birthdate, Email, ContactNo, Address, Department, Position) " +
                        "VALUES (@userID, @passWord, @firstName, @lastName, @middleInit, @gender, @birthDate, @email, @contactNo, @address, @department, @position); " +
                        "SELECT SCOPE_IDENTITY();",
                        connection);

                    command.Parameters.AddWithValue("@userID", employee.userID);
                    command.Parameters.AddWithValue("@passWord", employee.passWord);
                    command.Parameters.AddWithValue("@firstName", employee.firstName);
                    command.Parameters.AddWithValue("@lastName", employee.lastName);
                    command.Parameters.AddWithValue("@middleInit", employee.middleInit);
                    command.Parameters.AddWithValue("@gender", employee.gender);
                    command.Parameters.AddWithValue("@birthDate", employee.birthDate);
                    command.Parameters.AddWithValue("@email", employee.email);
                    command.Parameters.AddWithValue("@contactNo", employee.contactNo);
                    command.Parameters.AddWithValue("@address", employee.address);
                    command.Parameters.AddWithValue("@department", employee.department);
                    command.Parameters.AddWithValue("@position", employee.position);

                    object result = command.ExecuteScalar();
                    int employeeId = Convert.ToInt32(result);
                    return employeeId;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error during registration: " + ex.Message, ex);
            }
        }

        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand(query, connection);

                    // Add parameters to the command
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    var adapter = new SqlDataAdapter(command);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error executing query: " + ex.Message, ex);
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_DB;Integrated Security=True");
        }
    }
}