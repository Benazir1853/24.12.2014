using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle= new Circle();
            Console.WriteLine("Give the Radius of circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            string diameter = Convert.ToString(aCircle.GetDiameter(radius));
            string perimeter = Convert.ToString(aCircle.GetPerimeter(radius));
            string area = Convert.ToString(aCircle.GetArea(radius));
            Console.WriteLine("Diameter: "+diameter+"\nPerimeter: "+perimeter+"\nArea:"+area);
            Console.Read();
        }
    }
}
