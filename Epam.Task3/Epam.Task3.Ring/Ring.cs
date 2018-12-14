using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Ring
{
    public class Circle
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Run()
        {
            return Math.PI * Radius * 2;
        }
    }


    public class Ring : Circle
    {

        public double RadiusMIN { get; set; }

        public double AreaMIN()
        {
            return Math.PI * RadiusMIN * RadiusMIN;
        }

        public double RunMIN()
        {
            return Math.PI * RadiusMIN * 2;
        }
    }

}
