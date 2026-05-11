namespace OOP_Finals_PayrollSystem
{
    public class Deductions
    {
        public double GrossPay;
        public string Position;
        public double Tax;
        public double Pagibig;
        public double SSS;
        public double Philhealth;
        public double hoursWorked;
        public double daysWorked;
        public double BasicSalary;

        public double Deduction;

        public double netPay;

        public double grossPay = 0;

        public double GetSSS()
        {
            SSS = BasicSalary * 0.15;
            return SSS;
        }

        public double GetPhilhealth()
        {
            Philhealth = BasicSalary * 0.05;
            return Philhealth;
        }

        public double GetPagibig()
        {
            Pagibig = BasicSalary * 0.04;
            return Pagibig;
        }

        public double GetTax()
        {
            Tax = BasicSalary * 0.15;
            return Tax;
        }

        public double GetDeduction()
        {
            Deduction = Tax + Pagibig + SSS + Philhealth;
            return Deduction;
        }

        public double GetNetPay()
        {
            netPay = BasicSalary - Deduction;
            return netPay;
        }

        public double GetBasicSalary()
        {
            BasicSalary = GrossPay * hoursWorked * daysWorked;
            return BasicSalary;
        }
    }
}