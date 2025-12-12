using System;

namespace Geometry
{
    public class Cylinder
    {
        private double radius;
        private double length;

        public Cylinder(double radius, double length)
        {
            this.radius = radius;
            this.length = length;
        }

        public double Area()
        {
            return 2 * Math.PI * radius * (radius + length);
        }

        public double Volume()
        {
            return Math.PI * radius * radius * length;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Cylinder radius={radius}, length={length}, area={Area()}, volume={Volume()}");
        }
    }
}
