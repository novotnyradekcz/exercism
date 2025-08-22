using System;
using System.Text.RegularExpressions;

public class LogParser
{
    public bool IsValidLine(string text) =>
        Regex.IsMatch(text, @"^\[[A-Z]{3}\]");

    public string[] SplitLogLine(string text)
    {
        var separator = new Regex(@"<[\^\*=-]+>");
        return separator.Split(text);
    }

    public int CountQuotedPasswords(string lines)
    {
        int counter = 0;
        string[] logLines = lines.Split(Environment.NewLine);
        foreach (string line in logLines)
            if (Regex.IsMatch(line, ".*\".*(?i:password).*\".*")) counter++;
        return counter;
    }

    public string RemoveEndOfLineText(string line) =>
        Regex.Replace(line, "end-of-line[0-9]+", "");

    public string[] ListLinesWithPasswords(string[] lines)
    {
        for (int i = 0; i < lines.Length; i++)
        {
            Match weakPassword = Regex.Match(lines[i], @"(?i:password)\w+");
            if (weakPassword == Match.Empty)
                lines[i] = $"--------: {lines[i]}";
            else
                lines[i] = $"{weakPassword.Value}: {lines[i]}";
        }
        return lines;
    }
}
