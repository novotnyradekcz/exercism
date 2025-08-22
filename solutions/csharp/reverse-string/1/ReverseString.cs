using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var result = "";
        foreach (char letter in input)
        {
            result = letter + result;
        }
        return result;
    }
}