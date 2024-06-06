using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Circle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Overload the + operator to calculate the sum of areas
        public static double operator +(Circle circle1, Circle circle2)
        {
            return Math.PI * (circle1.Radius * circle1.Radius + circle2.Radius * circle2.Radius);
        }

        // Overload the - operator to calculate the area difference
        public static double operator -(Circle circle1, Circle circle2)
        {
            return Math.Abs(Math.PI * (circle1.Radius * circle1.Radius - circle2.Radius * circle2.Radius));
        }
    }

