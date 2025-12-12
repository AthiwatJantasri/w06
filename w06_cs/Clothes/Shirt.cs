using System;

namespace Clothes
{
    // Enum สำหรับสี
    public enum Color
    {
        Red, Blue, Green, Black, White
    }

    // Enum สำหรับขนาด
    public enum Size
    {
        Small, Medium, Large, XL
    }

    public class Shirt
    {
        // Attributes แบบ private
        private Color color;
        private Size size;
        private double price;

        // Constructor แบบมี parameter ครบ
        public Shirt(Color color, Size size, double price)
        {
            this.color = color;
            this.size = size;
            this.price = price;
        }

        // Constructor แบบไม่มี parameter (default)
        public Shirt() : this(Color.White, Size.Medium, 299.0) { }

        // Getter และ Setter
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // Method แสดงผล
        public void PrintInfo()
        {
            Console.WriteLine($"Shirt [Color={color}, Size={size}, Price={price}]");
        }
    }
}
