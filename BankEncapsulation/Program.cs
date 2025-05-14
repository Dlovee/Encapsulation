namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount be = new BankAccount(); // ✅ Create ONE instance

            while (true) // ✅ Keep the same instance in a loop
            {
                Console.WriteLine("How much $$$ do you want to deposit? (Enter 0 to exit)");
                double amountToDeposit = double.Parse(Console.ReadLine());

                if (amountToDeposit == 0) break; // ✅ Exit condition

                be.Deposit(amountToDeposit); // ✅ Adds to existing balance

                double userBalance = be.GetBalance();
                Console.WriteLine($"Your current balance is: {userBalance, 0:c}");
            }
        }
    }
}