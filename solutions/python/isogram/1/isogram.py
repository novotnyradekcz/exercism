"""A simple function for checking whether a string is an isogram"""

def is_isogram(string):
    filtered = string.lower()
    for letter in filtered:
        if letter.isalpha() and filtered.count(letter) > 1:
            return False
    return True
