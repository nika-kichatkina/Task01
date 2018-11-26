using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NON_NEGATIVE_SUM
{
    class NON_NEGATIVE_SUM
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random r = new Random();
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                array[i] = r.Next(-10, 10);
                Console.Write(array[i] + " ");

                if (array[i] > 0) sum += array[i];
            }

            Console.WriteLine();
            Console.WriteLine("Сумма всех положительных элементов: " + sum);
        }
    }
}
