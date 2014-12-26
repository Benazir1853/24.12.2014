using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {

        public double GetDiameter(double radius)
        {
            return radius*2;

        }
        public double GetPerimeter(double radius)
        {
            return radius * 2*Math.PI;

        }
        public double GetArea(double radius)
        {
            return radius * radius*Math.PI;

        }
    }
}
