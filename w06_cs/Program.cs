using Clothes;
using Geometry;

class Program
{
    static void Main(string[] args)
    {
        // ทดสอบ Shirt
        Shirt s = new Shirt(Color.Red, Size.Large, 499.0);
        s.PrintInfo();

        // ทดสอบ Circle
        Circle c = new Circle(10);
        c.PrintInfo();

        // ทดสอบ Cylinder
        Cylinder cy = new Cylinder(5, 20);
        cy.PrintInfo();

        // ทดสอบ Rectangle
        Rectangle r = new Rectangle(4, 6);
        r.PrintInfo();
    }
}

