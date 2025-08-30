using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Selecter
    {
        public void select()
        {
            switch (prongram.Method)
            {
                case
                    '+':
                    Console.WriteLine($"Your Result is :{prongram.Plus}");
                    break;

                case '-': Console.WriteLine($"Your Result is :{prongram.Mainus}");
                    break;

                    case '*': Console.WriteLine($"Your Result is :{ prongram.Multiply}");
                    break;


                case '/'
                    : if (prongram.number == 0)
                    {
                        Console.WriteLine("Error");
                    }

                    else
                    {
                        prongram.Result = prongram.number / prongram.number2;
                        Console.WriteLine($"Your Result is :{prongram.Result}");
                    }
                    break;

                    return;
            }
        }
    }
}
