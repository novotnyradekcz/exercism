"""Functions used in preparing Guido's gorgeous lasagna.

Learn about Guido, the creator of the Python language:
https://en.wikipedia.org/wiki/Guido_van_Rossum

This is a module docstring, used to describe the functionality
of a module and its functions and/or classes.
"""


EXPECTED_BAKE_TIME = 40 # how long it takes to bake the lasagna
PREPARATION_TIME = 2 # how long it takes to prepare one layer

def bake_time_remaining(elapsed_bake_time: int):
    """Calculate the bake time remaining.

    :param elapsed_bake_time: int - baking time already elapsed.
    :return: int - remaining bake time (in minutes) derived from 'EXPECTED_BAKE_TIME'.

    Function that takes the actual minutes the lasagna has been in the oven as
    an argument and returns how many minutes the lasagna still needs to bake
    based on the `EXPECTED_BAKE_TIME`.
    """

    return EXPECTED_BAKE_TIME - elapsed_bake_time

def preparation_time_in_minutes(number_of_layers: int):
    """Calculate the preparation time.

    :param number_of_layers: int - how many layers we want the lasagna to have.
    return: int - how long the preparation will take

    Function that takes the desired number of layers as an argument
    and returns the overall preparation time calculated using
    the constant `PREPARATION_TIME` which is how long it takes
    to prepare one layer.
    """

    return PREPARATION_TIME * number_of_layers

def elapsed_time_in_minutes(number_of_layers: int, elapsed_bake_time: int):
    """Calculate the total elapsed time.

    :param number_of_layers: int - how many layers we want the lasagna to have.
    :param elapsed_bake_time: int - baking time already elapsed.
    return: int - how much time has elapsed since the start of cooking

    Function that takes the desired number of layers as the first argument
    and the time the lasagnea has spent in he oven as the second argument
    and returns the overall elapsed cooking time calculated with the help of
    the preparation_time_in_minutes() function.
    """

    return preparation_time_in_minutes(number_of_layers) + elapsed_bake_time
