using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4
{
    public class Triangle
    {
        private double sidesA;
        private double sidesB;
        private double sidesC;

        public double SidesA { get; set; }
        public double SidesB { get; set; }
        public double SidesC { get; set; }

        public double S(double A, double B, double C)
        {
            double p = (SidesA + SidesB + SidesC) / 2;
            double formulaGerona = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return formulaGerona;
        }

        public double P(double A, double B, double C)
        {
            return A + B + C;
        }

        public Triangle(double a, double b, double c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
                {
                SidesA = a;
                SidesB = b;
                SidesC = c;
            }
            else
            {
                Console.WriteLine("the triangle does not exist!");
            }
        }


    }

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("enter sides A and B and C: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a,b,c);
            Console.WriteLine("area of a triangle: " + triangle.P(a, b, c));
            Console.WriteLine("perimeter of a triangle: " + triangle.S(a, b, c));
        }
    }
}
