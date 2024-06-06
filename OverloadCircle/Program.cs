using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadCircle
{

    class Program
    {
        static void Main(string[] args)
        {
            double radius1 = 5.0;
            double radius2 = 3.0;

            Circle circle1 = new Circle(radius1);
            Circle circle2 = new Circle(radius2);

            double sumOfAreas = circle1 + circle2;
            double areaDifference = circle1 - circle2;

            Console.WriteLine($"Sum of areas: {sumOfAreas}");
            Console.WriteLine($"Area difference: {areaDifference}");
            Console.ReadKey();
        }
    }
}
