from enum import Enum

class Color(Enum):
    RED = "Red"
    BLUE = "Blue"
    GREEN = "Green"
    BLACK = "Black"
    WHITE = "White"

class Size(Enum):
    SMALL = "Small"
    MEDIUM = "Medium"
    LARGE = "Large"
    XL = "XL"

class Shirt:
    def __init__(self, color=Color.WHITE, size=Size.MEDIUM, price=299.0):
        self.__color = color
        self.__size = size
        self.__price = price

    def print_info(self):
        print(f"Shirt [Color={self.__color.value}, Size={self.__size.value}, Price={self.__price}]")
