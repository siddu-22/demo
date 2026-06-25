using System;

class Program
{
    static void Main()
    {
        // Method 1: Simple multiplication with hardcoded values
        int num1 = 5;
        int num2 = 10;
        int result = num1 * num2;
        Console.WriteLine($"Multiplication of {num1} and {num2} = {result}");

        // Method 2: Taking input from user
        Console.WriteLine("\nEnter first number:");
        int firstNum = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter second number:");
        int secondNum = int.Parse(Console.ReadLine());
        
        int product = firstNum * secondNum;
        Console.WriteLine($"Product: {firstNum} × {secondNum} = {product}");

        // Method 3: Using a function
        int answer = Multiply(7, 8);
        Console.WriteLine($"\nUsing function: {answer}");
    }

    // Function to multiply two numbers
    static int Multiply(int a, int b)
    {
        return a * b;
    }
}
