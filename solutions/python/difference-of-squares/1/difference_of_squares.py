"""
Finding the difference between the square of the sum 
and the sum of the squares of the first N numbers.
"""

def square_of_sum(number):
    return sum([*range(1, number + 1)]) ** 2

def sum_of_squares(number):
    return sum(map(lambda x: x * x, [*range(1, number + 1)]))

def difference_of_squares(number):
    return square_of_sum(number) - sum_of_squares(number)
