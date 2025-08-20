#include "all_your_base.h"

int64_t magnitude(int16_t base, size_t exponent)
{
    int64_t result = 1;
    for (size_t i = 0; i < exponent; i++)
        result *= (int64_t)base;
    return result;
}

int8_t check_input(int8_t *digits, size_t input_length, int16_t input_base, int16_t output_base)
{
    if (input_length < 1)
        return 1;
    
    if (input_base < 2 || output_base < 2)
        return 1;
    
    for (size_t i = 0; i < input_length; i++)
    {
        if (digits[i] < 0 || (int16_t)digits[i] >= input_base)
            return 1;
    }
    return 0;
}

size_t rebase(int8_t *digits, int16_t input_base, int16_t output_base, size_t input_length)
{
    if (check_input(digits, input_length, input_base, output_base))
    {
        digits[0] = 0;
        return 0;
    }

    int64_t number = 0;
    for (size_t i = 0; i < input_length; i++)
        number += digits[i] * magnitude(input_base, input_length - i - 1);
    
    int8_t output_digits[DIGITS_ARRAY_SIZE] = { 0 };
    size_t output_length = 0;
    if (number == 0)
    {
        digits[0] = 0;
        return 1;
    }

    while (number > 0)
    {
        output_digits[output_length] = (int8_t)(number % (int64_t)output_base);
        number /= (int64_t)output_base;
        output_length++;
    }
    
    for (size_t i = 0; i < output_length; i++)
        digits[i] = output_digits[output_length - i - 1];
    return output_length;
}