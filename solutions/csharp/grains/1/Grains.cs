using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException("Square must be larger than 0 and smaller or equal to 64.");
        }
        return (ulong)Math.Pow(2, n - 1);
    }

    public static ulong Total() => ulong.MaxValue;
}