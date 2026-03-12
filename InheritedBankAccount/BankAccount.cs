using System;

SavingsAccount sa = new SavingsAccount("SA-001", 5000, 0.05);
Console.WriteLine("Savings Account");
sa.Deposit(1000);
sa.AddInterest();
Console.WriteLine($"Balance: PHP {sa.Balance:N2}");

Console.WriteLine();

CheckingAccount ca = new CheckingAccount("CA-001", 3000, 1000);
Console.WriteLine("Checking Account");
ca.Withdraw(3500);
Console.WriteLine($"Balance : PHP {ca.Balance:N2}");
class BankAccount
{
    private string accountNumber;
    protected double balance;

    public BankAccount (string accnum, double initialbal)
    {
        accountNumber = accnum;
        balance = initialbal;
    }
    public void Deposit (double amount)
    {
        if (amount <= 0)
        { 
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }
        else
        { 
            balance += amount;
            Console.WriteLine($"Deposited PHP {amount:N2}");
        }
    }
    
    public void Withdraw (double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrew PHP {amount:N2}");
        }
    }

    public double Balance
    {
        get { return balance; } // returns the current balance of the account (accessors)
        set { balance = value; } // allows updating the balance of the account (mutators)
    }
}

// Child Class 1: Savings Account

class SavingsAccount : BankAccount
{
    public double interestRate;

    public SavingsAccount (string accnum, double initialbal, double rate)
        : base (accnum, initialbal) // this is calling the constructor of the parent class (BankAccount) or the super() in Java
    {
        interestRate = rate;
    }

    public void AddInterest()
    {
        double interest = balance * interestRate; // since balance is protected, we can access it directly in the child class
        balance += interest;
        Console.WriteLine($"Added interest: PHP {interest:N2}");
    }
}

// Child Class 2: Checking Account
class CheckingAccount : BankAccount
{
    public double overdraftLimit;

    public CheckingAccount (string accnum, double initialbal, double limit)
        : base (accnum, initialbal)
    {
        overdraftLimit = limit;
    }

    public void Withdraw(double amount)
    {
        if (balance + overdraftLimit >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew PHP {amount:N2}");
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded.");
        }
    }
}