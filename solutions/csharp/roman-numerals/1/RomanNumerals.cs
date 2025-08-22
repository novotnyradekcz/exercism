using System;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        string roman = "";
        while (value >= 1000)
        {
            roman += "M";
            value -= 1000;
        }
        while (value >= 900)
        {
            roman += "CM";
            value -= 900;
        }
        while (value >= 500)
        {
            roman += "D";
            value -= 500;
        }
        while (value >= 400)
        {
            roman += "CD";
            value -= 400;
        }
        while (value >= 100)
        {
            roman += "C";
            value -= 100;
        }
        while (value >= 90)
        {
            roman += "XC";
            value -= 90;
        }
        while (value >= 50)
        {
            roman += "L";
            value -= 50;
        }
        while (value >= 40)
        {
            roman += "XL";
            value -= 40;
        }
        while (value >= 10)
        {
            roman += "X";
            value -= 10;
        }
        while (value >= 9)
        {
            roman += "IX";
            value -= 9;
        }
        while (value >= 5)
        {
            roman += "V";
            value -= 5;
        }
        while (value >= 4)
        {
            roman += "IV";
            value -= 4;
        }
        while (value >= 1)
        {
            roman += "I";
            value -= 1;
        }
        return roman;
    }
}