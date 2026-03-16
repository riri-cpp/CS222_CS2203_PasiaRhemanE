using System;

IPayment p1 = new CashPayment();
IPayment p2 = new CreditCardPayment();
IPayment p3 = new GCashPayment();

p1.Pay(500);
p2.Pay(1200);
p3.Pay(250);

interface IPayment
{
    void Pay(double amount);
}

class CashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount:C} using cash.");
    }
}

class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount:C} using credit card.");
    }
}

class GCashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount:C} using GCash.");
    }
}
