"""A function for finding a square root of natural numbers"""

def square_root(number):
    for num in range(number + 1):
        if num * num == number:
            return num
    return 0
