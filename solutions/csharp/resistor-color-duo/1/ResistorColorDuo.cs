using System;
using System.Collections.Generic;

public static class ResistorColorDuo
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
    
    public static int Value(string[] colors)
    {
        int number = 0;
        foreach (string color in colors[..2])
        {
            number = 10 * number + _colors[color];
        }
        return number;
    }
}
