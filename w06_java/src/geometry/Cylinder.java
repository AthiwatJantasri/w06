package geometry;

public class Cylinder {
    private double radius;
    private double length;

    public Cylinder(double radius, double length) {
        this.radius = radius;
        this.length = length;
    }

    public double area() {
        return 2 * Math.PI * radius * (radius + length);
    }

    public double volume() {
        return Math.PI * radius * radius * length;
    }

    public void printInfo() {
        System.out.println("Cylinder radius=" + radius + ", length=" + length +
                           ", area=" + area() + ", volume=" + volume());
    }
}
