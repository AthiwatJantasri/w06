#include <iostream>
using namespace std;

namespace Clothes {
    enum class Color { RED, BLUE, GREEN, BLACK, WHITE };
    enum class Size { SMALL, MEDIUM, LARGE, XL };

    class Shirt {
    private:
        Color color;
        Size size;
        double price;

    public:
        Shirt(Color c, Size s, double p) : color(c), size(s), price(p) {}
        Shirt() : Shirt(Color::WHITE, Size::MEDIUM, 299.0) {}

        Color getColor() const { return color; }
        void setColor(Color c) { color = c; }

        Size getSize() const { return size; }
        void setSize(Size s) { size = s; }

        double getPrice() const { return price; }
        void setPrice(double p) { price = p; }

        void printInfo() const {
            cout << "Shirt [Color=" << static_cast<int>(color)
                 << ", Size=" << static_cast<int>(size)
                 << ", Price=" << price << "]" << endl;
        }
    };
}
