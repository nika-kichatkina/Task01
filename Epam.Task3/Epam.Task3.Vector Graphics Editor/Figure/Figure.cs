using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Vector_Graphics_Editor.Figure
{
    public class Figure
    {
        public double X1 { get;  }
        public double X2 { get;  }

        public Figure (double x1, double x2)
        {
            this.X1 = x1;
            this.X2 = x2;
        }

        public void ShowFigure()
        {
            Console.WriteLine("There will be a figure");
        }

        public void ShowСoordinates(double x1, double x2)
        {
            Console.WriteLine("Coordinate: " + this.X1 + " " + this.X2);
        }

    }
}
