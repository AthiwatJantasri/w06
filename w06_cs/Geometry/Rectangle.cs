using System;

namespace Geometry
{
    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Area()
        {
            return width * height;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Rectangle width={width}, height={height}, area={Area()}");
        }
    }
}
