using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1._10._2D_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];

            Random r = new Random();
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = r.Next(10);
                    Console.Write(array[i, j] + " ");
                    if ((i + j) % 2 == 0) sum += array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма равна: " + sum);
        }
    }
}
