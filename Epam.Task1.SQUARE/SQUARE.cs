using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.SQUARE
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите положительное нечетное целое число");
            string s = System.Console.ReadLine();
            int N = int.Parse(s);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                   
                    if ((N / 2 == j) && (N / 2 == i)) System.Console.Write(" ");
                    else System.Console.Write("*");
                    
                }
                System.Console.WriteLine();
            }
        }
    }
}
