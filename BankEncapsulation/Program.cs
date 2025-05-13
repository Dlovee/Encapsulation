namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount be = new BankAccount();

            Console.WriteLine("How much $$$ do you want to deposit?");
            double ammountToDeposit = double.Parse(Console.ReadLine());
            
            be.Deposit(ammountToDeposit);
            
            double userBalance = be.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance, 0:c}");
        }
    }
}
