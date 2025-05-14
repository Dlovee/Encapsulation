namespace BankEncapsulation;

public class BankAccount
{
    private double _balance;
    

    public void Deposit(double amount)
    {
        Console.WriteLine($"Deposited: {amount, 0:c}. New balance: {_balance, 0:c}");
        _balance += amount;
    }

    public double GetBalance()
    {
        return _balance;
    }

}