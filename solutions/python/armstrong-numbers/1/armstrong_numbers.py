"""
A function for finding Armstrong numbers.

An Armstrong number is a number that is the sum of its own digits each raised to the power of the number of digits.
"""

def is_armstrong_number(number):
    n = number
    num_digits = 0
    while n >= 1:
        n /= 10
        num_digits += 1
    if number == 0:
        num_digits = 1
    digits = [int(d) for d in str(number)]
    return number == sum(map(lambda x: x ** num_digits, digits))