#include "all_your_base.h"

namespace all_your_base {
    bool check_input(std::vector<unsigned int> input_digits, unsigned int input_base, unsigned int output_base) {
    if (input_base < 2 || output_base < 2)
        throw std::invalid_argument("Base must be larger than 1.");
    
    for (unsigned int digit : input_digits)
    {
        if (digit >= input_base)
            throw std::invalid_argument("Input digit cannot be equal to or larger than input base.");
    }

    if (input_digits.size() < 1)
        return true;
    return false;
}
    
    std::vector<unsigned int> convert(unsigned int input_base, std::vector<unsigned int> input_digits, unsigned int output_base) {
        std::vector<unsigned int> converted;
        if (check_input(input_digits, input_base, output_base))
            return converted;
        int number = 0;
        for (unsigned int i = 0; i < input_digits.size(); i++)
            number += input_digits[i] * std::pow(input_base, input_digits.size() - i - 1);
        
        if (number == 0)
            return converted;

        while (number > 0)
        {
            converted.insert(converted.begin(), number % (int)output_base);
            number /= (int)output_base;
        }
        
        return converted;
    }
}  // namespace all_your_base
