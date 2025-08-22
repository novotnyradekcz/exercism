using System;
using System.Globalization;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB) => $"{studentA,29} ♡ {studentB,-29}";

    public static string DisplayBanner(string studentA, string studentB)
    {
        string[] separatedStudentA = studentA.Split(' ');
        string[] separatedStudentB = studentB.Split(' ');
        return $@"
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {separatedStudentA[0][0]}. {separatedStudentA[1][0]}.  +  {separatedStudentB[0][0]}. {separatedStudentB[1][0]}.     **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *
            ";
    }

    public static string DisplayGermanExchangeStudents(string studentA, string studentB, DateTime start, float hours) => String.Format(new CultureInfo("de-DE"), "{0} and {1} have been dating since {2:d} - that's {3:n2} hours", studentA, studentB, start, hours);
}
