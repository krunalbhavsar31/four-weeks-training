namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingAcc = new SavingsAccount(123456789, 1000);
            savingAcc.Deposit(100);
            savingAcc.Withdraw(50);

            CheckingAccount checkingAcc = new CheckingAccount(1010101010, 2000);
            checkingAcc.Deposit(1000);
            checkingAcc.Withdraw(500);

            CheckingAccount ca1 = new CheckingAccount(121516, 100000);
            ca1.Deposit(10);
        }
    }

    abstract class BankAccount
    {
        public long AccountNumber;
        public double Balance;
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
    }

    class SavingsAccount : BankAccount
    {
        double interestRate;

        public SavingsAccount(long AccountNumber, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }

        override
        public void Deposit(double amount)
        {
            this.Balance += amount;
            Console.WriteLine($"{amount}Rs was deposited to your account number {this.AccountNumber}, your current balance is {this.Balance}");
        }

        override
        public void Withdraw(double amount)
        {
            this.Balance -= amount;
            Console.WriteLine($"{amount}Rs was withdrew from your account number {this.AccountNumber}, your current balance is {this.Balance}");
        }
    }

    class CheckingAccount : BankAccount
    {
        double overdraftLimit;

        public CheckingAccount(long AccountNumber, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }

        override
        public void Deposit(double amount)
        {
            this.Balance += amount;
            Console.WriteLine($"{amount}Rs was deposited to your account number {this.AccountNumber}, your current balance is {this.Balance}");
        }

        override
        public void Withdraw(double amount)
        {
            this.Balance -= amount;
            Console.WriteLine($"{amount}Rs was withdrew from your account number {this.AccountNumber}, your current balance is {this.Balance}");
        }

    }
}