using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Finals_PayrollSystem
{
    /// <summary>
    /// Manages the currently logged-in user's session data
    /// </summary>
    public static class CurrentUser
    {
        public static int EmployeeID { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string MiddleInit { get; set; }

        public static string GetFullName()
        {
            return $"{FirstName} {MiddleInit} {LastName}";
        }

        public static void Clear()
        {
            EmployeeID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            MiddleInit = string.Empty;
        }
    }
}
