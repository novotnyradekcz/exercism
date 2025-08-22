using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        if (r > 10)
        {
            return 0;
        }
        else if (r > 5)
        {
            return 1;
        }
        else if (r > 1)
        {
            return 5;
        }
        else
        {
            return 10;
        }
    }
}
