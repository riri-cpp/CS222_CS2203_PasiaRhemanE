using System;

Pentagon p1 = new Pentagon();
Pentagon p2 = new Pentagon(5);

Console.WriteLine("Pentagon p1");
Console.WriteLine("-------------------------");
p1.display();

Console.WriteLine();

Console.WriteLine("Pentagon p2");
Console.WriteLine("-------------------------");
p2.display();
public class Pentagon
{
    private double side;

    public Pentagon(){
        side = 0;
    }
    public Pentagon(double side)
    {
        this.side = side;
    }
    public static double getPerimeter(double side)
    {
        double perimeter = 5 * side;
        return perimeter;
    }
    public static double getArea(double side)
    {
        double area = (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(side, 2)) / 4;
        return area;
    }

    public void display()
    {
        Console.WriteLine($"Side length: {side}");
        Console.WriteLine($"Perimeter: {getPerimeter(side):F3}");
        Console.WriteLine($"Area: {getArea(side):F3}");
    }
}