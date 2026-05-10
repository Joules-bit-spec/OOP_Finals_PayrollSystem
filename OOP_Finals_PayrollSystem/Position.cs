using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Finals_PayrollSystem
{
    public class Position : Deductions
    {
        public double GetPositionRate()
        {
            if(Position == "Service Technician")
            {
                grossPay = 140;
            }
            else if(Position == "Detailer")
            {
                grossPay = 70;
            }
            else if(Position == "Inventory Clerk")
            {
                grossPay = 144;
            }
            else if(Position == "Sales Consultant")
            {
                grossPay = 212;
            }
            else if (Position == "Finance Specialist")
            {
                grossPay = 180;
            }
            else if (Position == "Title Clerk")
            {
                grossPay = 130;
            }
            else if (Position == "Bookkeeper")
            {
                grossPay = 250;
            }
            else if (Position == "Branch Manager")
            {
                grossPay = 180;
            }
            else if (Position == "Service Advisor")
            {
                grossPay = 90;
            }
            return grossPay;
        }
    }
}
