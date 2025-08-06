using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Program p = new Program();
        p.RunCalculator();
    }

    public void RunCalculator()
    {
        while (true)
        {
            Console.WriteLine("\n--- Complex Calculator ---");
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Invalid input for first number.");
                continue;
            }

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Invalid input for second number.");
                continue;
            }

            double result = 0;
            bool validOp = true;
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                        validOp = false;
                    }
                    else
                    {
                        result = a / b;
                    }
                    break;
                default:
                    Console.WriteLine($"Unknown operator: {op}");
                    validOp = false;
                    break;
            }

            if (validOp)
            {
                Console.WriteLine($"Result: {a} {op} {b} = {result}");
            }

            Console.Write("Do you want to perform another calculation? (y/n): ");
            string cont = Console.ReadLine();
            if (!string.IsNullOrEmpty(cont) && cont.Trim().ToLower() != "y")
            {
                Console.WriteLine("Exiting calculator. Goodbye!");
                break;
            }
        }
    }
}