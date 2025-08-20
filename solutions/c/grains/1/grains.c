#include "grains.h"

uint64_t square(uint8_t index)
{
    if (index == 0 || index > 64)
        return (0);
    uint64_t result = 1;
    for (uint8_t i=1; i<index; i++)
        result *= 2;
    return (result);
}

uint64_t total(void)
{
    uint64_t result = 0;
    for (int i=1; i<=64; i++)
        result += square(i);
    return (result);
}