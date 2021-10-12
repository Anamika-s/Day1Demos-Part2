using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int ch;
            Console.WriteLine("Enter Value of x");
            x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Value of y");
            y = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter choice");
            ch = Convert.ToByte(Console.ReadLine());
            if(ch==1)
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
            else if(ch==2)
            Console.WriteLine("Difference of {0} and {1} is {2}", x, y, (x - y));
            else if(ch==3)
            Console.WriteLine("Product of {0} and {1} is {2}", x, y, (x * y));
            else if(ch==4)

            Console.WriteLine("Quotient of {0} and {1} is {2}", x, y, (x / y));
            else if(ch==5)
            Console.WriteLine("Remainder of {0} and {1} is {2}", x, y, (x % y));
            else
                Console.WriteLine("Invalid Choice");
        }
    }
}
