namespace BankEncapsulation;

public class BankAccount
{
    private double _balance;
    

    public void Deposit(double ammount)
    {
        Console.WriteLine($"Simulating a deposit of {ammount, 0:c} to your account!");
        _balance = ammount;
    }

    public double GetBalance()
    {
        return _balance;
    }

}