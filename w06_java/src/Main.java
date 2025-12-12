import clothes.Shirt;
import clothes.Shirt.Color;
import clothes.Shirt.Size;
import geometry.Circle;
import geometry.Cylinder;
import geometry.Rectangle;

public class Main {
    public static void main(String[] args) {
        // ทดสอบ Shirt
        Shirt s = new Shirt(Color.BLUE, Size.MEDIUM, 350.0);
        s.printInfo();

        // ทดสอบ Circle
        Circle c = new Circle(10);
        c.printInfo();

        // ทดสอบ Cylinder
        Cylinder cy = new Cylinder(5, 20);
        cy.printInfo();

        // ทดสอบ Rectangle
        Rectangle r = new Rectangle(4, 6);
        r.printInfo();
    }
}
