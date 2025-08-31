def roman(number):
    def recursiveRoman(arab, rom):
        if (arab == 0):
            return rom
        if (arab >= 1000):
            return recursiveRoman(arab - 1000, rom + "M")
        if (arab >= 900):
            return recursiveRoman(arab - 900, rom + "CM")
        if (arab >= 500):
            return recursiveRoman(arab - 500, rom + "D")
        if (arab >= 400):
            return recursiveRoman(arab - 400, rom + "CD")
        if (arab >= 100):
            return recursiveRoman(arab - 100, rom + "C")
        if (arab >= 90):
            return recursiveRoman(arab - 90, rom + "XC")
        if (arab >= 50):
            return recursiveRoman(arab - 50, rom + "L")
        if (arab >= 40):
            return recursiveRoman(arab - 40, rom + "XL")
        if (arab >= 10):
            return recursiveRoman(arab - 10, rom + "X")
        if (arab >= 9):
            return recursiveRoman(arab - 9, rom + "IX")
        if (arab >= 5):
            return recursiveRoman(arab - 5, rom + "V")
        if (arab >= 4):
            return recursiveRoman(arab - 4, rom + "IV")
        return recursiveRoman(arab - 1, rom + "I")

    return recursiveRoman(number, "")

