using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength <= 0)
        {
            throw new ArgumentException("Slice length must be a positive integer.");
        }
        if (sliceLength > numbers.Length)
        {
            throw new ArgumentException("Slice length cannot be longer than input string length.");
        }
        int sliceCount = numbers.Length - sliceLength + 1;
        var slices = new string[sliceCount];
        for (int i = 0; i < sliceCount; i++)
        {
            slices[i] = numbers.Substring(i, sliceLength);
        }
        return slices;
    }
}