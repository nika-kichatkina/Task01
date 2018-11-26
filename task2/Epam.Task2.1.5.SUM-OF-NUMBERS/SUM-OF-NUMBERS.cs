using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.SUM_OF_NUMBERS
{
    class SUM_OF_NUMBERS
    {
        static void Main(string[] args)
        {

            int sum = 0;

            for (int i = 0; i < 100; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }

            Console.WriteLine("Сумма равна: " + sum);
        }
    }
}
