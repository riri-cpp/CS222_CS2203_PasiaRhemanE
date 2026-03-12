using System;

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