#include "Clothes/Shirt.cpp"
#include "Geometry/Circle.cpp"
#include "Geometry/Cylinder.cpp"
#include "Geometry/Rectangle.cpp"
#include "Geometry/Earth.cpp"

using namespace Clothes;
using namespace Geometry;

int main() {
    Shirt s(Color::RED, Size::LARGE, 499.0);
    s.printInfo();

    Circle c(10);
    c.printInfo();

    Cylinder cy(5, 20);
    cy.printInfo();

    Rectangle r(4, 6);
    r.printInfo();

    return 0;
}
