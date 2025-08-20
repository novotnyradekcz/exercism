#include "luhn.h"

bool luhn(const char *num)
{
    int sum = 0;
    int digits = 0;
    int parity = 1;
    for (int i = strlen(num) - 1; i >= 0; i--)
    {
        if (num[i] == ' ' || num[i] == '\t')
            continue ;
        if (num[i] < '0' || num[i] > '9')
            return false;
        digits++;
        int digit = (num[i] - '0') * parity;
        if (digit > 9)
            digit -= 9;
        parity = 3 - parity;
        sum += digit;
    }
    return digits > 1 && sum % 10 == 0;
}
