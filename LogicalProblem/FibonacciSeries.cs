using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblem
{
    class FibonacciSeries
    {
        public void Fibonacci()
        {
            Console.WriteLine("enter number of terms");
            int number = Convert.ToInt32(Console.ReadLine());
            int firstterm = 0;
            int secondterm = 1;
            int nextterm = 0;
            for (int i = 0; i < number; i++)
            {
                if (i == firstterm)
                {
                    Console.Write(firstterm + " , ");
                    continue;
                }
                if (i == secondterm)
                {
                    Console.Write(secondterm + " , ");
                    continue;
                }
                nextterm = firstterm + secondterm;
                firstterm = secondterm;
                secondterm = nextterm;
                Console.Write(nextterm + " , ");

            }
        }
    }
}
