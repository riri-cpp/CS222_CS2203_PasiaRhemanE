using System;

Console.Write("Enter principal amount: ");
double principal = double.Parse(Console.ReadLine());

Console.Write("Enter rate of interest: ");
double IntRate = double.Parse(Console.ReadLine());

Console.Write("Enter time in years: ");
int time = int.Parse(Console.ReadLine());

double SimpleInterest = (principal * IntRate * time) / 100;

Console.WriteLine("Simple Interest: {0:F2}", SimpleInterest);
