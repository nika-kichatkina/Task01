using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Vector_Graphics_Editor.Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select geometric figure: ");
                Console.WriteLine("1.Circle");
                Console.WriteLine("2.Line");
                Console.WriteLine("3.Rectangle");


                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        {
                            Console.WriteLine("space coordinatese: ");
                            double x1 = double.Parse(Console.ReadLine());
                            double x2 = double.Parse(Console.ReadLine());

                            Console.WriteLine("entrer radius: ");
                            double radius = double.Parse(Console.ReadLine());

                            Circle CIRCLE = new Circle(x1, x2, radius);

                            Console.WriteLine("Circle");
                            CIRCLE.ShowFigure();
                            CIRCLE.ShowСoordinates(x1, x2, radius);

                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("space coordinatese: ");
                            double x1 = double.Parse(Console.ReadLine());
                            double x2 = double.Parse(Console.ReadLine());

                            Figure LINE = new Line(x1, x2);

                            Console.WriteLine("Line");
                            LINE.ShowFigure();
                            LINE.ShowСoordinates(x1, x2);

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("space coordinatese: ");
                            double x1 = double.Parse(Console.ReadLine());
                            double x2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("enter side: ");
                            double a = double.Parse(Console.ReadLine());
                            double b = double.Parse(Console.ReadLine());


                            Rectangle LINE = new Rectangle(x1, x2, a, b);

                            Console.WriteLine("Rectangle");
                            LINE.ShowFigure();
                            LINE.ShowСoordinates(x1, x2, a, b);

                            break;
                        }
                    default:
                        Console.WriteLine("Select the correct number");
                        break;
                }
            }
        }
    }
}
