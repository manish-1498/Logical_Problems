using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblem
{
    class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 2)
                Console.WriteLine(number + " is a Even Prime number");
            if (number % 2 == 0 || number == 0 || number == 1)
                Console.WriteLine(number + " Not a prime number");
            else
                Console.WriteLine(number + " is a prime number");
        }
    }
}
