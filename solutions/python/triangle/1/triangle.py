"""
A set of functions for checking whether a triangle 
is equilateral, isosceles or scalene.
"""

def triangle(sides):
    return sides[0] + sides[1] > sides[2] and sides[1] + sides[2] > sides[0] and sides[2] + sides[0] > sides[1]

def equilateral(sides):
    return triangle(sides) and sides[0] == sides[1] and sides[1] == sides[2]

def isosceles(sides):
    return triangle(sides) and (sides[0] == sides[1] or sides[1] == sides[2] or sides[2] == sides[0])

def scalene(sides):
    return triangle(sides) and not equilateral(sides) and not isosceles(sides)
