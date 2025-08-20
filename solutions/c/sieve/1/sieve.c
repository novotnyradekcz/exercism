#include "sieve.h"

uint32_t sieve(uint32_t limit, uint32_t *primes, size_t max_primes)
{
    uint32_t numbers[limit + 1];
    uint32_t i;
    uint32_t j;
    numbers[0] = 0;
    numbers[1] = 0;
    for (i = 2; i <= limit; i++)
        numbers[i] = i;
    for (i = 2; i <= limit; i++)
    {
        for (j = 2; i * j <= limit; j++)
            numbers[i * j] = 0;
    }
    j = 0;
    for (i = 0; i <= limit; i++)
    {
        if (numbers[i] != 0) {
            primes[j] = numbers[i];
            j++;
            if (j == max_primes)
                return (j);
        }
    }
    return (j);
}