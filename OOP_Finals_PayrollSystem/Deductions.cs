using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public double Deduction;

        public double netPay;

        public double grossPay = 0;

        public double GetSSS()
        {
            SSS = GrossPay * 0.15;
            return SSS;
        }

        public double GetPhilhealth()
        {
            Philhealth = GrossPay * 0.05;
            return Philhealth;
        }

        public double GetPagibig()
        {
            Pagibig = GrossPay * 0.04;
            return Pagibig;
        }

        public double GetTax()
        {
            Tax = GrossPay * 0.15;
            return Tax;
        }

        public double GetDeduction()
        {
            Deduction = Tax + Pagibig + SSS + Philhealth;
            return Deduction;
        }

        public double GetNetPay()
        {
            netPay = GrossPay - Deduction;
            return netPay;
        }

        public double GetBasicSalary()
        {
            return GrossPay * hoursWorked * daysWorked;
        }
    }
}
