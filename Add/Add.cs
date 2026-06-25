using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        double sum = a + b;
        Console.WriteLine($"Sum: {sum}");
    }
}