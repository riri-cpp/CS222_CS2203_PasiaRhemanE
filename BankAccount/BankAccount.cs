using System;

BankAccount ba = CreateAccount();
ShowWelcome(ba);

bool exit = false;
while (!exit)
{
   exit = ShowMenu(ba);

}
static BankAccount CreateAccount()
{
    BankAccount account = new BankAccount();
    Console.Write("Enter account holder's name: ");
    account.AccountHolder = Console.ReadLine()!;

    Console.Write("Enter initial balance: ");
    account.Balance = double.Parse(Console.ReadLine()!);

    return account;
}

static void ShowWelcome(BankAccount account)
{
    Console.WriteLine($"Welcome, {account.AccountHolder}!");
    Console.WriteLine($"Initial Balance: PHP {account.Balance:N2}\n");
}

static bool ShowMenu(BankAccount account)
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
            DisplayBalance(account);
            break;
        case "2":
            DepositAmount(account);
            break;
        case "3":
            WithdrawAmount(account);
            break;
        case "4":
            Console.WriteLine("Thank you for using our banking system.");
            return true;
        default:
            Console.WriteLine("Invalid option, please try again.\n");
            break;
    }
    Console.WriteLine();
    return false;
}

static void DisplayBalance(BankAccount account)
{
    Console.WriteLine($"Current Balance: PHP {account.Balance:N2}\n");
}

static void DepositAmount(BankAccount account)
{
    Console.Write("Enter deposit amount: ");
    double amount = double.Parse(Console.ReadLine()!);
    account.deposit(amount);
    Console.WriteLine($"New Balance: PHP {account.Balance:N2}\n");
}

static void WithdrawAmount(BankAccount account)
{
    Console.Write("Enter withdrawal amount: ");
    double amount = double.Parse(Console.ReadLine()!);
    account.withdraw(amount);
    Console.WriteLine($"New Balance: PHP {account.Balance:N2}\n");
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
        if (amount >= 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: PHP {amount:N2}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Deposit failed.");
        }
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