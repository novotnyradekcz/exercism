#include "collatz_conjecture.h"

int steps(int start)
{
    if (start <= 0)
        return -1;
    int i = 0;
    int num = start;
    while (num > 1)
    {
        if (num % 2)
            num = 3 * num + 1;
        else
            num /= 2;
        i++;
    }
    return i;
}