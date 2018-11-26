
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.ANOTHER_TRIANGLE

{
    class ANOTHER_TRIANGLE


    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, большее нуля: ");
            int N = int.Parse(Console.ReadLine());

            int section1 = N; // sectoin1 и section2 - отрезок звездочек на каждой строке.
            int section2 = N;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= (N * 2) - 1; j++)
                {
                    if (j == section1)
                    {
                        for (int k = section1; k <= section2; k++)
                        {
                            Console.Write("*");
                        }
                        section1--;
                        section2++;
                        Console.WriteLine();
                        //continue;
                        break;
                    }
                    else Console.Write(" ");
                }
            }
        }
    }
}
