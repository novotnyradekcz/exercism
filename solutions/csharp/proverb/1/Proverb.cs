using System;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        int proverbLength = subjects.Length;
        var proverbLines = new string[proverbLength];

        for (int i = 0; i < proverbLength; i++)
        {
            if (i == proverbLength - 1)
            {
                proverbLines[i] = $"And all for the want of a {subjects[0]}.";
            }
            else
            {
                proverbLines[i] = $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.";
            }
        }

        return proverbLines;
    }
}