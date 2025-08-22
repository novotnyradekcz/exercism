using System;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    // equality operators
    public static bool operator == (CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies don't match");
        return left.amount == right.amount;
    }

    public static bool operator != (CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies don't match");
        return left.amount != right.amount;
    }
    // comparison operators
    public static bool operator < (CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies don't match");
        return left.amount < right.amount;
    }

    public static bool operator > (CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies don't match");
        return left.amount > right.amount;
    }
    // arithmetic operators
    public static CurrencyAmount operator + (CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies don't match");
        return new CurrencyAmount(left.amount + right.amount, left.currency);
    }

    public static CurrencyAmount operator - (CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies don't match");
        return new CurrencyAmount(left.amount - right.amount, left.currency);
    }

    public static CurrencyAmount operator * (CurrencyAmount currencyAmount, decimal multiple) =>
        new CurrencyAmount(currencyAmount.amount * multiple, currencyAmount.currency);

    public static CurrencyAmount operator / (CurrencyAmount currencyAmount, decimal divisor) =>
        new CurrencyAmount(currencyAmount.amount / divisor, currencyAmount.currency);
    // type conversion operators
    public static explicit operator double (CurrencyAmount currencyAmount) =>
        (double)currencyAmount.amount;

    public static implicit operator decimal (CurrencyAmount currencyAmount) =>
        currencyAmount.amount;
}
