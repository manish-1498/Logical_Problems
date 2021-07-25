using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblem
{
    class PerfectNumbers
    {
        public void Perfect()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int duplinumber = number;
            int perfectsum = 0;
            for (int i = 1; i <= duplinumber; i++)
            {
                if (i % duplinumber == 0)
                {
                    perfectsum += i;
                    duplinumber = duplinumber / i;

                }
            }
            if (number == perfectsum)
                Console.WriteLine(number + "is a perfect number");
            else
                Console.WriteLine(number + " is not a perfect number");
        }
    }
}
