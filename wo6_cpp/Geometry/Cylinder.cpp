#include <iostream>
#include <cmath>
using namespace std;

namespace Geometry {
    class Cylinder {
    private:
        double radius;
        double length;

    public:
        Cylinder(double r, double l) : radius(r), length(l) {}
        double area() const { return 2 * M_PI * radius * (radius + length); }
        double volume() const { return M_PI * radius * radius * length; }

        void printInfo() const {
            cout << "Cylinder radius=" << radius
                 << ", length=" << length
                 << ", area=" << area()
                 << ", volume=" << volume() << endl;
        }
    };
}
