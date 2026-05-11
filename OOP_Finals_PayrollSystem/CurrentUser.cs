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
        public static string Position { get; set; }
        public static string Department { get; set; }

        // Payroll data
        public static double HourlyRate { get; set; }

        public static double BasicSalary { get; set; }
        public static double WithholdingTax { get; set; }
        public static double PhilHealth { get; set; }
        public static double SSS { get; set; }
        public static double PagIbig { get; set; }
        public static double TotalDeductions { get; set; }
        public static double NetPay { get; set; }

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
            Position = string.Empty;
            Department = string.Empty;

            HourlyRate = 0;
            BasicSalary = 0;
            WithholdingTax = 0;
            PhilHealth = 0;
            SSS = 0;
            PagIbig = 0;
            TotalDeductions = 0;
            NetPay = 0;
        }
    }
}