using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.ARRAY_PROCESSING
{
    class ARRAY_PROCESSING

    {
        static int[] Sort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(10);
            }

            Sort(array);

            Console.WriteLine("Наименьший элемент: " + array[0]);
            Console.WriteLine("Наибольший элемент: " + array[array.Length-1]);


            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}
