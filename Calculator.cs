using System;
using static System.Console;

class Program
{
    static void Main()
    {
        WriteLine("Enter frist Number :");
        int num1 = Convert.ToInt32(Console.ReadLine());

        WriteLine("Enter Second Number :");
        int num2 = Convert.ToInt32(Console.ReadLine());

        WriteLine("Chose an operation: (+ ,- ,* ,/)");
        string operation = Console.ReadLine();

        int result = 0;

        if (operation == "+") { result = num1 + num2; }
        else if (operation == "-") { result = num1 - num2; }
        else if (operation == "*") { result = num1 * num2; }
        else if (operation == "/")
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                WriteLine("Error");
                return;
            }
        }
         Console.WriteLine($"Result: {result}");
    
    }
}
