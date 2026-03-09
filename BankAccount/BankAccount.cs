using System;

BankAccount account = new BankAccount();
Console.Write("Enter account holder's name: ");
account.AccountHolder = Console.ReadLine()!;

Console.Write("Enter initial balance: ");
account.Balance = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Welcome, {account.AccountHolder}!");
Console.WriteLine($"Initial Balance: PHP {account.Balance:N2}\n");

bool exit = false;
while (!exit)
{
    Console.WriteLine("=== BANK MENU ===");
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine()!;
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine($"Current Balance: PHP {account.Balance:N2}");
            break;
        case "2":
            Console.Write("Enter deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine()!);
            account.deposit(depositAmount);
            Console.WriteLine($"New Balance: PHP {account.Balance:N2}");
            break;
        case "3":
            Console.Write("Enter amount to withdraw: ");
            double withdrawAmount = double.Parse(Console.ReadLine()!);
            account.withdraw(withdrawAmount);
            Console.WriteLine($"New Balance: PHP {account.Balance:N2}");
            break;
        case "4":
            Console.WriteLine("Thank you for using our banking system.");
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid option, please try again.");
            break;
    }
}
public class BankAccount
{
    private string accountHolder;
    private double balance; 

    public string AccountHolder
    {
        get { return accountHolder; }
        set { accountHolder = value; }
    }

    public double Balance
    {
        get { return balance; }
        set
        {
            if(value >= 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Invalid balance, try again.");
            }
        } 
    }

    public void deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: PHP {amount:N2}");
    }

    public void withdraw(double amount)
    {
        if(amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: PHP {amount:N2}");
        }
        else
        {
            Console.WriteLine("Insufficient balance. Withdrawal failed.");
        }
    }
}