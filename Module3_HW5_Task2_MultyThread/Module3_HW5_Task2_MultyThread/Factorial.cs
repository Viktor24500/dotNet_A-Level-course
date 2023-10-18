using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW5_Task2_MultyThread
{
    public class Factorial
    {
        public static int FactorialRecursion(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * FactorialRecursion(number - 1);
            }
        }

        //public static void FactorialCalc()
        //{
        //    FactorialRecursion(10);
        //}
    }
}