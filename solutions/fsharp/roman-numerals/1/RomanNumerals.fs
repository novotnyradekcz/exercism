module RomanNumerals

let roman arabicNumeral = 
    let rec toRoman arabic roman =
        match arabic with
        | x when x >= 1000 -> toRoman (arabic - 1000) (roman + "M")
        | x when x >= 900 -> toRoman (arabic - 900) (roman + "CM")
        | x when x >= 500 -> toRoman (arabic - 500) (roman + "D")
        | x when x >= 400 -> toRoman (arabic - 400) (roman + "CD")
        | x when x >= 100 -> toRoman (arabic - 100) (roman + "C")
        | x when x >= 90 -> toRoman (arabic - 90) (roman + "XC")
        | x when x >= 50 -> toRoman (arabic - 50) (roman + "L")
        | x when x >= 40 -> toRoman (arabic - 40) (roman + "XL")
        | x when x >= 10 -> toRoman (arabic - 10) (roman + "X")
        | x when x >= 9 -> toRoman (arabic - 9) (roman + "IX")
        | x when x >= 5 -> toRoman (arabic - 5) (roman + "V")
        | x when x >= 4 -> toRoman (arabic - 4) (roman + "IV")
        | x when x >= 1 -> toRoman (arabic - 1) (roman + "I")
        | _ -> roman
    toRoman arabicNumeral ""
    