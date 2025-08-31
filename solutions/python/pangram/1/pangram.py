"""A simple function for checking whether a sentence is a pangram"""

def is_pangram(sentence):
    for letter in "abcdefghijklmnopqrstuvwxyz":
        if letter not in sentence.lower():
            return False
    return True
