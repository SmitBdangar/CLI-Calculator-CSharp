using ConsoleApp1;
using System;

class prongram
{

    public static int Result;
    public static int Multiply;
    public static int Plus;
    public static int Mainus;
    
    
    public static int Method;

    public static int number;
    public static int number2;

    static void Main()
    {
        Console.Write("Enter your first a number:");
        number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your second a number:");
        number2 = Convert.ToInt32(Console.ReadLine());

        Plus = number + number2;
        Multiply = number - number2;
        Mainus = number * number2;

        Console.Write("Select your method: +, -, *, / :");
        
        Method = Convert.ToChar(Console.ReadLine());

        Selecter p = new Selecter();
        p.select();
    }
}
