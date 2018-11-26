using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.NO_POSITIVE
{
    class NO_POSITIVE
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[10, 10, 10];

            Random r = new Random(); 

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        array[x, y, z] = r.Next(-10, 10);
                        Console.Write(array[x, y, z] + " ");

                        if (array[x, y, z] > 0) array[x, y, z] = 0;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Новый массив:");

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        Console.Write(array[x, y, z] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }


    }
}
