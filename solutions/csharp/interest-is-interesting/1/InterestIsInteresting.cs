static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0m) 
        {
            return (float)(3.213);
        }
        else if (balance < 1000m)
        {
            return (float)(0.5);
        }
        else if (balance < 5000m)
        {
            return (float)(1.621);
        }
        return (float)(2.475);
    }

    public static decimal Interest(decimal balance) => balance * (decimal)InterestRate(balance) / 100m;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);
        
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance) {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years += 1;
        }
        return years;
    }
}
