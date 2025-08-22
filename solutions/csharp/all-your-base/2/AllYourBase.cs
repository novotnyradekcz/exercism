using System;
using System.Collections.Generic;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        var converted = new List<int>();
        if (inputBase < 2 || outputBase < 2)
            throw new ArgumentException("Base must be at least 2.");
        foreach (int digit in inputDigits)
            if (digit < 0 || digit >= inputBase)
                throw new ArgumentException("Digit cannot be negative or equal to or larger than input base.");
        int number = 0;

        for (int i = 0; i < inputDigits.Length; i++)
            number += inputDigits[i] * (int)Math.Pow(inputBase, inputDigits.Length - i - 1);
        
        if (number == 0)
        {
            converted.Insert(0, 0);
            return converted.ToArray();
        }
        while (number > 0)
        {
            converted.Insert(0, number % outputBase);
            number = number / outputBase;
        }
        
        return converted.ToArray();
    }
}