#include <iostream>
#include <cmath>
using namespace std;

namespace Geometry {
    class Circle {
    private:
        double radius;

    public:
        Circle(double r) : radius(r) {}
        double getRadius() const { return radius; }
        void setRadius(double r) { radius = r; }
        double area() const { return M_PI * radius * radius; }

        void printInfo() const {
            cout << "Circle radius=" << radius
                 << ", area=" << area() << endl;
        }
    };
}
