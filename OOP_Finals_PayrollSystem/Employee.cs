using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Finals_PayrollSystem
{
    public class Employee
    {
        private int EmployeeID;
        private string FirstName;
        private string LastName;
        private string MiddleInitial;
        private string Gender;
        private string Birthday;
        private string Email;
        private string ContactNumber;
        private string Address;
        private string Department;
        private string Position;

        private int UserID;
        private string Password;

        public int GetEmployeeID()
        {
            return EmployeeID;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public string GetMiddleInitial()
        {
            return MiddleInitial;
        }

        public string GetFullName()
        {
            return $"{FirstName} {MiddleInitial}. {LastName}";
        }

        public string GetGender()
        {
            return Gender;
        }

        public string GetBirthday()
        {
            return Birthday;
        }

        public string GetEmail()
        {
            return Email;
        }

        public string GetContactNumber()
        {
            return ContactNumber;
        }

        public string GetAddress()
        {
            return Address;
        }

        public string GetDepartment()
        {
            return Department;
        }

        public string GetPosition()
        {
            return Position;
        }

        public int GetUserID()
        {
            return UserID;
        }

        public string GetPassword()
        {
            return Password;
        }
    }
}