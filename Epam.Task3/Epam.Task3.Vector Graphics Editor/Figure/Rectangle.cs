using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Vector_Graphics_Editor.Figure
{
    class Rectangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle(double x1, double x2, double a, double b) : base(x1, x2)
        {
            this.A = a;
            this.B = b;
        }

        public void ShowСoordinates(double x1, double x2, double a, double b)
        {
            Console.WriteLine("Coordinate: " + base.X1 + " " + base.X2);
            Console.WriteLine("Parties: " + this.A + " " + this.B);
        }
    }
}
