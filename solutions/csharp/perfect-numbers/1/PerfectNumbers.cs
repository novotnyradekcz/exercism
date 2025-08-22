using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static int AliquotSum(int number)
    {
        var factors = new List<int>();
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                factors.Add(i);
            }
        }
        return factors.Sum();
    }
    
    public static Classification Classify(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException("Only positive integers can be classified.");
        }
        if (AliquotSum(number) == number)
        {
            return Classification.Perfect;
        }
        else if (AliquotSum(number) > number)
        {
            return Classification.Abundant;
        }
        else
        {
            return Classification.Deficient;
        }
    }
}
