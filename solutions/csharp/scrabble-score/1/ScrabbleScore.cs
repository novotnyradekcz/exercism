using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int sum = 0;
        foreach (char letter in input.ToUpper())
        {
            switch (letter)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                case 'L':
                case 'N':
                case 'R':
                case 'S':
                case 'T':
                    sum += 1;
                    break;
                case 'D':
                case 'G':
                    sum += 2;
                    break;
                case 'B':
                case 'C':
                case 'M':
                case 'P':
                    sum += 3;
                    break;
                case 'F':
                case 'H':
                case 'V':
                case 'W':
                case 'Y':
                    sum += 4;
                    break;
                case 'K':
                    sum += 5;
                    break;
                case 'J':
                case 'X':
                    sum += 8;
                    break;
                case 'Q':
                case 'Z':
                    sum += 10;
                    break;
            }
        }
        return sum;
    }
}