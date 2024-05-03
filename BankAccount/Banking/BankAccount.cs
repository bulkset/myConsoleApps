namespace BankAccount.Banking{
    public abstract class BankAccount{
    protected string accountHolder;
    protected double balance;

    public BankAccount(string accountHolder, double balance){
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);

    public double CheckBalance(){
        return balance;
    }
}
}