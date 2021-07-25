using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblem
{
    class Reverse
    {
        public void Reverseanumber()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder, i = 0;
            int reverse = 0;
            int duplinumber = number;
            while (i < duplinumber)
            {
                remainder = duplinumber % 10;
                reverse = (reverse * 10) + remainder;
                duplinumber /= 10;
            }
            if (reverse == number)
                Console.WriteLine("Original number and reverse number are same");
            else
                Console.WriteLine("SORRY enter another number and check for reverse");
        }
    }
}
