package clothes;

public class Shirt {
    // Enum สำหรับสี
    public enum Color {
        RED, BLUE, GREEN, BLACK, WHITE
    }

    // Enum สำหรับขนาด
    public enum Size {
        SMALL, MEDIUM, LARGE, XL
    }

    // Attributes แบบ private
    private Color color;
    private Size size;
    private double price;

    // Constructor แบบมี parameter ครบ
    public Shirt(Color color, Size size, double price) {
        this.color = color;
        this.size = size;
        this.price = price;
    }

    // Constructor แบบไม่มี parameter (default)
    public Shirt() {
        this(Color.WHITE, Size.MEDIUM, 299.0); // เรียก constructor แรก
    }

    // Getter และ Setter
    public Color getColor() { return color; }
    public void setColor(Color color) { this.color = color; }

    public Size getSize() { return size; }
    public void setSize(Size size) { this.size = size; }

    public double getPrice() { return price; }
    public void setPrice(double price) { this.price = price; }

    // Method แสดงผล
    public void printInfo() {
        System.out.println("Shirt [Color=" + color + ", Size=" + size + ", Price=" + price + "]");
    }

    // ทดสอบการใช้งาน
    public static void main(String[] args) {
        Shirt s1 = new Shirt(Color.RED, Size.LARGE, 499.0);
        Shirt s2 = new Shirt(); // default
        s1.printInfo();
        s2.printInfo();
    }
}
