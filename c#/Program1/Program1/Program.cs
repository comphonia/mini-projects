using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables defined
            int amount1 = 8;
            int amount2 = 5;
            int intTotal = 0;
            decimal amount3 = 8.687m;
            decimal amount4 = 2.748m;
            decimal decimalTotal = 0;

            //Sum of 2 integers
            intTotal = amount1 + amount2;
            Console.WriteLine("The sum of the two integers are = "+intTotal);

            //Sum of 2 decimal variables
            decimalTotal = amount3 + amount4;
            Console.WriteLine("The sum of the two decimal values are = " + decimalTotal);

            //Product of 2 integers
            intTotal = amount1 * amount2;
            Console.WriteLine("The product of the two integers are = " + intTotal);

            //Product of 2 decimal variables
            decimalTotal = amount3 * amount4;
            Console.WriteLine("The product of the two decimal values are = " + decimalTotal);

            //Quotient of 2 integers
            intTotal = amount1 / amount2;
            Console.WriteLine("The quotient of the two integers are = " + intTotal);

            //Quotient of 2 decimal variables
            decimalTotal = amount3 / amount4;
            Console.WriteLine("The quotient of the two decimal values are = " + decimalTotal);
            Console.ReadKey();
        }
    }
}
