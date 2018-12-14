using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Round
{
    public class Round
    {
        public double Radius { get; }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public Round(double radius)
        {
            if (radius <= 0)
            {
                Console.WriteLine("Mistake! The value is incorrect. Value will be replaced by module");
                this.Radius = (Math.Abs(radius));
            }
            else
            {
                this.Radius = radius;
            }
        }

        public Round()
        {
            this.Radius = 0;
        }

        public double Length()
        {
            return Math.PI * Radius * 2;
        }


    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты центра круга: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите радиус круга: ");
            double newRadius = double.Parse(Console.ReadLine());

            Round round = new Round(newRadius);

            Console.WriteLine("Площадь круга = {0}", round.GetArea());
            Console.WriteLine("Длина  = {0}", round.Length());


        }
    }
}

