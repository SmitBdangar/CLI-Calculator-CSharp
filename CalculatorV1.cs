using System;

class Program1
{
    static int NumberOne;
    static int NumberTwo;
    static int Result;
    static string Operator;

    static void Main(string[] args)
    {
        GetNumber();
        DoOperation();
        FinalResult();
    }

    static void GetNumber()
    {
        Console.WriteLine("Enter first number:");
        NumberOne = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        NumberTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select operation (+, -, *, /):");
        Operator = Console.ReadLine();
    }

    static void DoOperation()
    {
        if (Operator == "+")
            Result = NumberOne + NumberTwo;
        else if (Operator == "-")
            Result = NumberOne - NumberTwo;
        else if (Operator == "*")
            Result = NumberOne * NumberTwo;
        else if (Operator == "/")
        {
            if (NumberTwo != 0)
                Result = NumberOne / NumberTwo;
            else
                Console.WriteLine("Error: Division by zero!");
        }
        else
            Console.WriteLine("Invalid operator!");
    }

    static void FinalResult()
    {
        Console.WriteLine($"Your Result is: {Result}");
    }
}
