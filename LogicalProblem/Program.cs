using System;

namespace LogicalProblem
{
    class Program
    {
        public void Viewprogram()
        {
            Console.WriteLine("WELCOME TO LOGICAL PROBLEMS");
            Console.WriteLine("1. Fibonacci Series\n" +
                "2.Perfect number\n" +
                "3.Prime number\n" +
                "4.Reverse\n" +
                "5.day of week\n" +
                "6.Temperature Conversion\n" +
                "7.Monthly payment\n" +
                "8.Decimal to binary");
            Console.WriteLine("enter the option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.Fibonacci();
                    break;
                case 2:
                    PerfectNumbers perfectnumber = new PerfectNumbers();
                    perfectnumber.Perfect();
                    break;
                case 3:
                    PrimeNumber primenumber = new PrimeNumber();
                    primenumber.Prime();
                    break;
                case 4:
                    Reverse reverse = new Reverse();
                    reverse.Reverseanumber();
                    break;
                case 5:
                    DayofWeek dw = new DayofWeek();
                    dw.Days();
                    break;
                case 6:
                    Temperature temp = new Temperature();
                    temp.Tempconversion();
                    break;
                case 7:
                    MonthlyPayment monthlypayment = new MonthlyPayment();
                    monthlypayment.Payment();
                    break;
                case 8:
                    DecimaltoBinary decimaltobinary = new DecimaltoBinary();
                    decimaltobinary.DtoB();
                    break;
                default:
                    Console.WriteLine("enter correct option");
                    break;
            }
            Console.WriteLine("\nDo you wants to see any other program.....if yes then preass Y or else  N");
            char yesno = Convert.ToChar(Console.ReadLine());
            if (yesno == 'Y' || yesno == 'y')
            {
                Console.WriteLine("........................................................................................");
                Viewprogram();
            }
        }
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Viewprogram();
        }
    }
}
