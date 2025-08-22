using System;
using System.Collections.Generic;
using System.Linq;

public static class ListOps
{
    public static int Length<T>(List<T> input)
    {
        int i = 0;
        foreach (T item in input)
            i++;
        return i;
    }

    public static List<T> Reverse<T>(List<T> input)
    {
        var output = new List<T>();
        foreach (T item in input)
            output.Insert(0, item);
        return output; 
    }

    public static List<TOut> Map<TIn, TOut>(List<TIn> input, Func<TIn, TOut> map)
    {
        var output = new List<TOut>();
        foreach (TIn item in input)
            output.Add(map(item));
        return output;
    }

    public static List<T> Filter<T>(List<T> input, Func<T, bool> predicate)
    {
        var output = new List<T>();
        foreach (T item in input)
            if (predicate(item))
                output.Add(item);
        return output;
    }

    public static TOut Foldl<TIn, TOut>(List<TIn> input, TOut start, Func<TOut, TIn, TOut> func)
    {
        TOut output = start;
        foreach (TIn item in input)
            output = func(output, item);
        return output;
    }

    public static TOut Foldr<TIn, TOut>(List<TIn> input, TOut start, Func<TIn, TOut, TOut> func)
    {
        input = Reverse(input);
        TOut output = start;
        foreach (TIn item in input)
            output = func(item, output);
        return output;
    }

    public static List<T> Concat<T>(List<List<T>> input)
    {
        var output = new List<T>();
        foreach (List<T> item in input)
            Append(output, item);
        return output;
    }

    public static List<T> Append<T>(List<T> left, List<T> right)
    {
        foreach (T item in right)
            left.Add(item);
        return left;
    }
}