#include "armstrong_numbers.h"

bool is_armstrong_number(int candidate)
{
    int digits = 0;
    int num = candidate;
    int tens[] = {1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000, 1000000000};
    if (num == 0)
        digits++;
    while (num > 0)
    {
        num /= 10;
        digits++;
    }
    int sum = 0;
    for (int i=0; i<digits; i++)
    {
        int digit = candidate / tens[digits - i - 1] % 10;
        int sumDigit = digit;
        for (int j=1; j<digits; j++)
            sumDigit *= digit;
        sum += sumDigit;
    }
    return (candidate == sum);
}