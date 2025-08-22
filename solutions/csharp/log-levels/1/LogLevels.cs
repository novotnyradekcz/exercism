using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int i = logLine.IndexOf(" ");
        string msg = logLine.Substring(i + 1);
        return msg.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int i = logLine.IndexOf("]");
        string lvl = logLine.Substring(1, i - 1);
        return lvl.ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
