using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder output = new StringBuilder(4 * identifier.Length);
        for (int i = 0; i < identifier.Length; i++)
        {
            if (identifier[i] == ' ')
                output.Append('_');
            else if (Char.IsControl(identifier[i]))
                output.Append("CTRL");
            else if (i + 1 < identifier.Length && identifier[i] == '-' && Char.IsLetter(identifier[i + 1]))
            {
                i++;
                output.Append(Char.ToUpper(identifier[i]));
            }
            else if (!Char.IsLetter(identifier[i]) || (identifier[i] >= '\u03AC' && identifier[i] <= '\u03CE'))
                continue;
            else
                output.Append(identifier[i]);
        }
    return output.ToString();
    }
}
