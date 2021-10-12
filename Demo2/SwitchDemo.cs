using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    class SwitchDemo
    {
        static void Main()
        {
            int x, y;
            int ch;
            Console.WriteLine("Enter Value of x");
            x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Value of y");
            y = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter choice");
            ch = Convert.ToByte(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
                    break;
                case 2:

                    Console.WriteLine("Difference of {0} and {1} is {2}", x, y, (x - y));
                    break;
                case 3:

                    Console.WriteLine("Product of {0} and {1} is {2}", x, y, (x * y));
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
                case 4:

                    Console.WriteLine("Quotient of {0} and {1} is {2}", x, y, (x / y));
                    break;
                case 5:
                    Console.WriteLine("Remainder of {0} and {1} is {2}", x, y, (x % y));
                    break;
                
            }
        }
    }
}
