"""
How many steps it takes to get from any number to 0 
following the principles of the collatz Conjecture.
"""

def steps(number):
    if number > 0:
        steps = 0
        while (number != 1):
            if number % 2 == 0:
                number /= 2
            else:
                number = 3 * number + 1
            steps += 1
        return steps
    else:
        raise ValueError("Only positive integers are allowed")
