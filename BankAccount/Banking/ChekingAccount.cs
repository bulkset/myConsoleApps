namespace BankAccount.Banking
{
    public class ChekingAccount : BankAccount
    {
        public ChekingAccount(string accountHolder, double balance) : base(accountHolder, balance)
        {
        }
        public override void Deposit(double amount)
        {
            balance += amount;
        }
        public override void Withdraw(double amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("ERROR: Balance is out of range for ChekingAccount");
            }
            balance -= amount;
        }
    }
}