import math

class Earth:
    G = 9.8
    RADIUS = 6.3781E6
    MASS = 5.97E24

class Circle:
    def __init__(self, radius):
        self.__radius = radius

    def area(self):
        return math.pi * self.__radius ** 2

    def print_info(self):
        print(f"Circle radius={self.__radius}, area={self.area()}")

class Cylinder:
    def __init__(self, radius, length):
        self.__radius = radius
        self.__length = length

    def area(self):
        return 2 * math.pi * self.__radius * (self.__radius + self.__length)

    def volume(self):
        return math.pi * self.__radius ** 2 * self.__length

    def print_info(self):
        print(f"Cylinder radius={self.__radius}, length={self.__length}, "
              f"area={self.area()}, volume={self.volume()}")

class Rectangle:
    def __init__(self, width, height):
        self.__width = width
        self.__height = height

    def area(self):
        return self.__width * self.__height

    def print_info(self):
        print(f"Rectangle width={self.__width}, height={self.__height}, area={self.area()}")
