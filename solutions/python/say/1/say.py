def under_twenty(number):
    if number == 1:
        return "one"
    if number == 2:
        return "two"
    if number == 3:
        return "three"
    if number == 4:
        return "four"
    if number == 5:
        return "five"
    if number == 6:
        return "six"
    if number == 7:
        return "seven"
    if number == 8:
        return "eight"
    if number == 9:
        return "nine"
    if number == 10:
        return "ten"
    if number == 11:
        return "eleven"
    if number == 12:
        return "twelve"
    if number == 13:
        return "thirteen"
    if number == 14:
        return "fourteen"
    if number == 15:
        return "fifteen"
    if number == 16:
        return "sixteen"
    if number == 17:
        return "seventeen"
    if number == 18:
        return "eighteen"
    if number == 19:
        return "nineteen"

def under_hundred(number):
    if number // 10 < 2:
        return under_twenty(number)
    output = ""
    if number // 10 == 2:
        output = "twenty"
    if number // 10 == 3:
        output = "thirty"
    if number // 10 == 4:
        output = "forty"
    if number // 10 == 5:
        output = "fifty"
    if number // 10 == 6:
        output = "sixty"
    if number // 10 == 7:
        output = "seventy"
    if number // 10 == 8:
        output = "eighty"
    if number // 10 == 9:
        output = "ninety"
    if number % 10 == 0:
        return output
    return output + "-" + under_twenty(number % 10)

def under_thousand(number):
    if number < 100:
        return under_hundred(number)
    output = ""
    if number // 100 == 1:
        output = "one"
    if number // 100 == 2:
        output = "two"
    if number // 100 == 3:
        output = "three"
    if number // 100 == 4:
        output = "four"
    if number // 100 == 5:
        output = "five"
    if number // 100 == 6:
        output = "six"
    if number // 100 == 7:
        output = "seven"
    if number // 100 == 8:
        output = "eight"
    if number // 100 == 9:
        output = "nine"
    if number % 100 == 0:
        return output + " hundred"
    return output + " hundred " + under_hundred(number % 100)

def say(number):
    if number < 0 or number > 999999999999:
        raise ValueError("input out of range")
    if number == 0:
        return "zero"
    output = ""
    if number >= 1000000000:
        output += under_thousand(number // 1000000000) + " billion "
    if number // 1000000 % 1000 != 0:
        output += under_thousand(number // 1000000 % 1000) + " million "
    if number // 1000 % 1000 != 0:
        output += under_thousand(number // 1000 % 1000) + " thousand "
    if number % 1000 != 0:
        output += under_thousand(number % 1000)
    return output.strip()
