using System;

// Creating objects
BankAccount sa = new SavingsAccount("SA-001", 5000);
BankAccount ca = new CheckingAccount("CA-001", 3000);

sa.Deposit(1000);
sa.Withdraw(2000);

Console.WriteLine();

ca.Deposit(500);
ca.Withdraw(3500);


// ===== Abstract Parent Class =====
abstract class BankAccount
{
    public string AccountNumber;
    protected double balance;

    public BankAccount(string accNum, double initialBalance)
    {
        AccountNumber = accNum;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    // Abstract method (no implementation)
    public abstract void Withdraw(double amount);
}


// ===== Child Class =====
class SavingsAccount : BankAccount
{
    public SavingsAccount(string accNum, double initialBalance)
        : base(accNum, initialBalance) { }

    public override void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine("Savings Withdraw: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }
}


// ===== Child Class =====
class CheckingAccount : BankAccount
{
    public CheckingAccount(string accNum, double initialBalance)
        : base(accNum, initialBalance) { }

    public override void Withdraw(double amount)
    {
        balance -= amount;
        Console.WriteLine("Checking Withdraw: " + amount);
    }
}