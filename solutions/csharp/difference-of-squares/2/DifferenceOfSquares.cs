using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var sum = 0;
        for (int i = 1; i <= max; i++)
            sum += i;
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        var sum = 0;
        for (int i = 1; i <= max; i++)
            sum += i * i;
        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
        => Math.Abs(CalculateSquareOfSum(max) - CalculateSumOfSquares(max));
}