"""A simple implementation of the rotational cipher"""

def rotate(text, key):
    result = ""
    for letter in text:
        if letter.islower():
            result += chr((ord(letter) - ord('a') + key) % 26 + ord('a'))
        elif letter.isupper():
            result += chr((ord(letter) - ord('A') + key) % 26 + ord('A'))
        else:
            result += letter
    return result
