using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var count = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        foreach (char n in sequence)
        {
            if (!count.Keys.Contains(n))
                throw new ArgumentException("Invalid nucleotide.");
            count[n] += 1;
        }
        return count;
    }
}