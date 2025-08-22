using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 1)
            throw new ArgumentOutOfRangeException("Argument must be a positive integer.");
        
        var sieve = Enumerable.Repeat(true, limit + 1).ToArray();
        var primes = new List<int>();

        for (int i = 2; i <= limit; i++)
        {
            if (sieve[i] == false)
                continue;

            primes.Add(i);
            
            for (int j = 2 * i; j <= limit; j += i)
                sieve[j] = false;
        }

        return primes.ToArray();
    }
}