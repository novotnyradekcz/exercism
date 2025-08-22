using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        int counter = 0;
        for (int c = 65; c <= 90; c++)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == (char)c || input[i] == (char)(c + 32))
                {
                    counter++;
                    break ;
                }
            }
        }
        if (counter == 26)
            return (true);
        return (false);
    }
}
