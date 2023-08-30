using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Class_Logger
{
    public static class Starter
    {
        public static void Run()
        {
            Random random = new Random();
            int i = 0;
            int operationAmount = 100;
            while (i < operationAmount)
            {
                int number = random.Next(1, 4);

                if (number == 1)
                {
                    Actions.InfoAction();
                }
                else if (number == 2)
                {
                    Actions.WarningAction();
                }
                else if (number == 3)
                {
                    Actions.ErrorAction();
                }
                i++;
            }
        }
    }
}
