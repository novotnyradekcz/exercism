using System;

public static class Luhn
{
    public static bool IsValid(string number)
    {
        int sum = 0;
        int digits = 0;
        int parity = 1;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (number[i] == ' ' || number[i] == '\t')
                continue ;
            if (number[i] < '0' || number[i] > '9')
                return false;
            digits++;
            int digit = (number[i] - '0') * parity;
            if (digit > 9)
                digit -= 9;
            parity = 3 - parity;
            sum += digit;
        }
        return digits > 1 && sum % 10 == 0;
    }
}