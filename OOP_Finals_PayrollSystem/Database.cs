using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OOP_Finals_PayrollSystem
{
    public class Database
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_DB;Integrated Security=True";

        public int RegisterEmployee(Employee employee)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                var command = new System.Data.SqlClient.SqlCommand("INSERT INTO Employees (userID, passWord, firstName, lastName, middleInit, gender, birthDate, email, contactNo, address, department, position) VALUES (@userID, @passWord, @firstName, @lastName, @middleInit, @gender, @birthDate, @email, @contactNo, @address, @department, @position)", connection);
                command.Parameters.AddWithValue("@userID", employee.userID);
                command.Parameters.AddWithValue("@passWord", employee.passWord);
                command.Parameters.AddWithValue("@firstName", Employee.firstName);
                command.Parameters.AddWithValue("@lastName", Employee.lastName);
                command.Parameters.AddWithValue("@middleInit", Employee.middleInit);
                command.Parameters.AddWithValue("@gender", employee.gender);
                command.Parameters.AddWithValue("@birthDate", employee.birthDate);
                command.Parameters.AddWithValue("@email", employee.email);
                command.Parameters.AddWithValue("@contactNo", employee.contactNo);
                command.Parameters.AddWithValue("@address", employee.address);
                command.Parameters.AddWithValue("@department", employee.department);
                command.Parameters.AddWithValue("@position", employee.position);
                return command.ExecuteNonQuery();
            }
        }

        internal DataTable ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_DB;Integrated Security=True");
        }
        
    }
}
