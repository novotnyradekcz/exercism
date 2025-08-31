"""A simple function for checking whether a number is a valid ISBN-10"""

def is_valid(isbn):
    isbnNum = isbn.replace('-', '')
    if len(isbnNum) != 10:
        return False
    result = 0
    for index in range(0, len(isbnNum)):
        if isbnNum[index] == 'X' and index == 9:
            num = 10
        elif isbnNum[index].isdigit():
            num = int(isbnNum[index])
        else:
            return False
        result += (10 - index) * num
    return result % 11 == 0
    
