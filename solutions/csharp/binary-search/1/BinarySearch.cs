using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int bottom = 0;
        int top = input.Length;

        while (bottom < top)
        {
            int mid = (bottom + top) / 2;
            int midItem = input[mid];
            if (value == midItem)
                return mid;
            if (value > midItem)
                bottom = mid + 1;
            else if (value < midItem)
                top = mid;
        }
        
        return -1;
    }
}