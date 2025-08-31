"""A simple function for checking if given year is a leap year."""

def leap_year(year):
    return year % 4 == 0 and (not year % 100 == 0 or year % 400 == 0)
