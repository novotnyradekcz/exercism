using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string log, string delimiter)
    {
        int idx = log.IndexOf(delimiter);
        return log.Substring(idx + delimiter.Length);
    }

    public static string SubstringBetween(this string log, string after, string before)
    {
        int startsAfter = log.IndexOf(after);
        int isLong = log.IndexOf(before) - startsAfter - after.Length;
        return log.Substring(startsAfter + after.Length, isLong);
    }
    
    public static string Message(this string log) => log.SubstringAfter("]: ");

    public static string LogLevel(this string log) => log.SubstringBetween("[", "]");
}