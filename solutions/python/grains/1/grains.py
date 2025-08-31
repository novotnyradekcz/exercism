"""
Functions for calculating the number of grains on a chessboard.
"""

def square(number):
    if number > 0 and number < 65:
        return 2 ** (number - 1)
    else:
        raise ValueError("square must be between 1 and 64")

def total():
    return sum(map(lambda x: 2 ** x, [*range(0, 64)]))
