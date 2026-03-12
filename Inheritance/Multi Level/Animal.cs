using System;

Puppy p = new Puppy();
p.Eat();  // Inherited from Animal
p.Bark(); // Inherited from Dog
p.Weep(); // Defined in Puppy

// base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating");
    }
}

// derived from Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking");
    }
}

// derived from Dog
class Puppy : Dog
{
    public void Weep()
    {
        Console.WriteLine("The puppy is weeping");
    }

}
