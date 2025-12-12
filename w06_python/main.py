from clothes.shirt import Shirt, Color, Size
from geometry.shapes import Circle, Cylinder, Rectangle

# ทดสอบ Shirt
s = Shirt(Color.RED, Size.LARGE, 499)
s.print_info()

# ทดสอบ Circle
c = Circle(10)
c.print_info()

# ทดสอบ Cylinder
cy = Cylinder(5, 20)
cy.print_info()

# ทดสอบ Rectangle
r = Rectangle(4, 6)
r.print_info()
