using System;

namespace Geometry
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Circle radius={radius}, area={Area()}");
        }
    }
}
