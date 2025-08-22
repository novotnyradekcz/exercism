using System;
using System.Collections.Generic;

public static class ResistorColorTrio
{
    private static Dictionary<string, int> _colors = new Dictionary<string, int> {
        { "black", 0 },
        { "brown", 1 },
        { "red", 2 },
        { "orange", 3 },
        { "yellow", 4 },
        { "green", 5 },
        { "blue", 6 },
        { "violet", 7 },
        { "grey", 8 },
        { "white", 9 }
    };
    
    public static string Label(string[] colors)
    {
        int number = 0;
        foreach (string color in colors[..2])
        {
            number = 10 * number + _colors[color];
        }
        number *= (int)Math.Pow((double)10, (double)_colors[colors[2]]);
        
        if (number > 1000)
        {
            return $"{number / 1000} kiloohms";
        }
        else
        {
            return $"{number} ohms";
        }
    }
}
