#include "roman_numerals.h"

namespace roman_numerals {
    std::string convert(int arabic)
    {
        std::string roman = "";
        std::string romans[] = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        int arabics[] = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        int numbers = 13;
        for (int i = 0; i < numbers; i++)
        {
            while (arabic >= arabics[i])
            {
                roman += romans[i];
                arabic -= arabics[i];
            }
        }
        return roman;
    }
}  // namespace roman_numerals
