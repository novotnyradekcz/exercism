using System;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var letters = new Dictionary<string, int>();
        foreach (var score in old)
        {
            foreach (var letter in score.Value)
            {
                letters[letter.ToLower()] = score.Key;
            }
        }
        return letters;
    }
}