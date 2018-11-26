using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.X_MAS_TREE
{
    class X_MAS_TREE
    {
        static void Main(string[] args)
        {
            Console.Write("Введите положительное число: ");
            int N = int.Parse(Console.ReadLine());

            int paragraph = N;       // paragraph необходим для "выравнивания" по центру
            for (int time = 1; time <= N; time++)     //за основу решения взят код из решения ANOTHER TRIANGLE, зацикленного нужное time.
            {
                paragraph--;
                int section1 = time; // sectoin1 и section2 - отрезок звездочек на каждой строке.
                int section2 = time;

                for (int i = 1; i <= time; i++)
                {
                    for (int k = paragraph; k > 0; k--)
                    {
                        if (time != N)
                        {
                            Console.Write(" ");
                        }
                    }
                    for (int j = 1; j <= (time * 2) - 1; j++)
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
}
