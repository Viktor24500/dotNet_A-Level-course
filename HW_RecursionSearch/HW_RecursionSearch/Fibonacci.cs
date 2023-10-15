using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_RecursionSearch
{
    public class Fibonacci
    {
        public static int FibonacciMethod(int number) 
        {
            if (number <= 1)
            {
                return number;
            }
            else
            {
                return FibonacciMethod(number - 1) + FibonacciMethod(number - 2);
            }
        }

        public static void FibonacciCalc()
        {
            FibonacciMethod(10);
        }
    }
}
