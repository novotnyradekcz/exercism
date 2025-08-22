using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var points = new List<int>();
        foreach (int item in multiples)
        {
            if (item == 0)
            {
                continue;
            }
            for (int i = item; i < max; i += item)
            {
                points.Add(i);
            }
        }
        return points.Distinct().Sum();
    }
}