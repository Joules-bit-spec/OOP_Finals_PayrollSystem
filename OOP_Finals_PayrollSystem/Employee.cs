namespace OOP_Finals_PayrollSystem
{
    public class Employee
    {
        public int userID { get; set; }
        public int employeeID { get; set; }
        public string passWord { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInit { get; set; }

        public string GetFullName()
        {
            return $"{firstName} {middleInit} {lastName}";
        }

        public string gender { get; set; }
        public string birthDate { get; set; }
        public string email { get; set; }
        public int contactNo { get; set; }
        public string address { get; set; }
        public string department { get; set; }
        public string position { get; set; }
    }
}