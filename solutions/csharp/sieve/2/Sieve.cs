using System;
using System.Collections.Generic;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 1)
            throw new ArgumentOutOfRangeException("Argument must be a positive integer.");
        
        var sieve = new bool[limit + 1];
        var primes = new List<int>();

        for (int i = 2; i <= limit; i++)
        {
            if (sieve[i])
                continue;

            primes.Add(i);
            
            for (int j = 2 * i; j <= limit; j += i)
                sieve[j] = true;
        }

        return primes.ToArray();
    }
}