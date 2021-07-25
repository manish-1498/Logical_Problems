using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblem
{
    class MonthlyPayment
    {
        public void Payment()
        {
            Console.WriteLine("enter Principal Loan Amount");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter Interesr");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter no of Years to pay");
            double Y = Convert.ToDouble(Console.ReadLine());
            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = P * r / 1 - Math.Pow((1 + r), (-n));
            Console.WriteLine("Monthly Payment is " + payment);
        }
    }
}
