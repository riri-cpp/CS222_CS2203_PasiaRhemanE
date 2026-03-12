using System;

Vehicle v = new Vehicle();
v.Move(); // Output: The vehicle is moving
Car c = new Car();
c.Move(); // Output: The car is driving
Motorcycle m = new Motorcycle();
m.Move(); // Output: The motorcycle is riding

class Vehicle
{
    public virtual void Move() // virtual method that can be overridden by derived classes
    {
        Console.WriteLine("The vehicle is moving");
    }
}

class Car : Vehicle
{
    public override void Move() // override the Move method to provide specific behavior for Car
    {
        Console.WriteLine("The car is driving");
    }
}

class Motorcycle : Vehicle
{
    public override void Move() // override the Move method to provide specific behavior for Motorcycle
    {
        Console.WriteLine("The motorcycle is riding");
    }
}   