using BankAccount.Banking;

namespace BankAccount
{
    class Program
    {
        static void Main()
        {
            BankAccount.Banking.BankAccount savingsAccount = new SavingAccounts("John", 1000);
            BankAccount.Banking.BankAccount checkingAccount = new ChekingAccount("Jane", 500);

            savingsAccount.Deposit(500);
            checkingAccount.Withdraw(200);

            Console.WriteLine($"Savings Account Balance: {savingsAccount.CheckBalance()}");
            Console.WriteLine($"Checking Account Balance: {checkingAccount.CheckBalance()}");
        }
    }
}