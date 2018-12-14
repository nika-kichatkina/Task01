using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Vector_Graphics_Editor.Figure
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double x1, double x2, double radius) : base(x1,x2)
        {
            this.Radius = radius;
        }

        public void ShowСoordinates(double x1, double x2, double radius)
        {
            Console.WriteLine("Coordinate: " + base.X1 + " " + base.X2);
            Console.WriteLine("Radius: " + this.Radius);
        }
    }
}
