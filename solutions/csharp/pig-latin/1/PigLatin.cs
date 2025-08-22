using System;
using System.Collections.Generic;

public static class PigLatin
{
    public static string Translate(string phrase)
    {
        string[] words = phrase.Split(' ');
        var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
        var output = new List<string>();
        foreach (string word in words)
        {
            if (word.Length == 2 && word[1] == 'y')
            {
                output.Add("y" + word[0].ToString() + "ay");
            }
            else if (vowels.Contains(word[0]) || word[..2] == "xr" || word[..2] == "yt")
            {
                output.Add(word + "ay");
            }
            else if (vowels.Contains(word[1]) && word[..2] != "qu")
            {
                output.Add(word[1..] + word[0] + "ay");
            }
            else if ((vowels.Contains(word[2]) || word[2] == 'y' || word[..2] == "qu") && word[1..3] != "qu")
            {
                output.Add(word[2..] + word[..2] + "ay");
            }
            else if (vowels.Contains(word[3]) || word[1..3] == "qu")
            {
                output.Add(word[3..] + word[..3] + "ay");
            }
        }
        return String.Join(" ", output);
    }
}