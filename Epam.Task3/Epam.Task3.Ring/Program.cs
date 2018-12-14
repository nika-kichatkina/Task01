using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Ring
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты центра окружности: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Введите радиусы кругов: ");

            Ring r1 = new Ring();
            Ring r2 = new Ring();

            r1.Radius = double.Parse(Console.ReadLine());
            r2.RadiusMIN = double.Parse(Console.ReadLine());

            Console.WriteLine("Площадь кольца равна: " + (r1.Area() + r2.AreaMIN()));
            Console.WriteLine("Сумма длины внешней и внутренней окружности: " + (r1.Run() + r2.RunMIN()));

        }
    }
}
