using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.RECTANGLE
{
    class RECTANGLE
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите стороны прямоуголиника.");
            
            int a = 0;
            int b = 0;
            bool flag = true;


            while (flag == true)
            {
                if ( (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))  && ((a > 0) && (b > 0)) )
                {
                    flag = false;
                }
                else
                {
                    
                    {
                        Console.WriteLine("Введите корректные данные");
                    }

                }


            }
                       
            Console.WriteLine("Площадь прямоугольника равна " + a * b);

        }
    }
}