#include <iostream>
using namespace std;

namespace Geometry {
    class Rectangle {
    private:
        double width;
        double height;

    public:
        Rectangle(double w, double h) : width(w), height(h) {}
        double getWidth() const { return width; }
        void setWidth(double w) { width = w; }
        double getHeight() const { return height; }
        void setHeight(double h) { height = h; }
        double area() const { return width * height; }

        void printInfo() const {
            cout << "Rectangle width=" << width
                 << ", height=" << height
                 << ", area=" << area() << endl;
        }
    };
}
