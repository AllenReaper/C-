class vendingMechin
{
    private decimal _balance; // Hidden from outside

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            _balance += amount;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}
