using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0m)
            return 3.213f;
        else if (balance < 1000m)
            return 0.5f;
        else if (balance < 5000m)
            return 1.621f;
        else
            return 2.475f;
    }

    public static decimal Interest(decimal balance)
    {
        return (decimal) InterestRate(balance) / 100m * balance;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal currentBalance = balance;
        int years = 0;
        while (currentBalance < targetBalance)
        {
            currentBalance = AnnualBalanceUpdate(currentBalance);
            years++;
        }
        return years;
    }
}
