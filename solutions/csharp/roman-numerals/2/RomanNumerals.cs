using System;
using System.Collections.Generic;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        string roman = "";
        var arabicToRoman = new Dictionary<string, int>();
        arabicToRoman.Add("M", 1000);
        arabicToRoman.Add("CM", 900);
        arabicToRoman.Add("D", 500);
        arabicToRoman.Add("CD", 400);
        arabicToRoman.Add("C", 100);
        arabicToRoman.Add("XC", 90);
        arabicToRoman.Add("L", 50);
        arabicToRoman.Add("XL", 40);
        arabicToRoman.Add("X", 10);
        arabicToRoman.Add("IX", 9);
        arabicToRoman.Add("V", 5);
        arabicToRoman.Add("IV", 4);
        arabicToRoman.Add("I", 1);
        foreach (KeyValuePair<string, int> number in arabicToRoman)
        {
            while (value >= number.Value)
            {
                roman += number.Key;
                value -= number.Value;
            }
        }
        return roman;
    }
}