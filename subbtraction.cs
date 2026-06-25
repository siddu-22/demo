using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine()!);

        double result = a - b;
        Console.WriteLine($"Result: {result}");
    }
}