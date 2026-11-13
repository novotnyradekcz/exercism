function to_roman(number)
    if number < 1 || number > 3999
        throw(ErrorException("Number must be between 1 and 3999!"))
    end
    
    function recursive_roman(arabic, roman)
        if arabic >= 1000
            return recursive_roman(arabic - 1000, roman * "M")
        end
        if arabic >= 900
            return recursive_roman(arabic - 900, roman * "CM")
        end
        if arabic >= 500
            return recursive_roman(arabic - 500, roman * "D")
        end
        if arabic >= 400
            return recursive_roman(arabic - 400, roman * "CD")
        end
        if arabic >= 100
            return recursive_roman(arabic - 100, roman * "C")
        end
        if arabic >= 90
            return recursive_roman(arabic - 90, roman * "XC")
        end
        if arabic >= 50
            return recursive_roman(arabic - 50, roman * "L")
        end
        if arabic >= 40
            return recursive_roman(arabic - 40, roman * "XL")
        end
        if arabic >= 10
            return recursive_roman(arabic - 10, roman * "X")
        end
        if arabic >= 9
            return recursive_roman(arabic - 9, roman * "IX")
        end
        if arabic >= 5
            return recursive_roman(arabic - 5, roman * "V")
        end
        if arabic >= 4
            return recursive_roman(arabic - 4, roman * "IV")
        end
        if arabic >= 1
            return recursive_roman(arabic - 1, roman * "I")
        end
        return roman
    end

    return recursive_roman(number, "")
end
