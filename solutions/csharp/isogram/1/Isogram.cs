using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        for (int i = 0; i < word.Length - 1; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                if (Char.IsLetter(word[i]) && Char.ToLower(word[i]) == Char.ToLower(word[j]))
                    return false;
            }
        }
        return true;
    }
}
