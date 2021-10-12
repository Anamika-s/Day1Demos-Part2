using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    class Sum_Average
    { // Take 10 numbers & display their sum & average
        static void Main()
        {
            int[] num = new int[10];
            int sum = 0;
            Console.WriteLine("Enter Numbers");
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToByte(Console.ReadLine());
                sum += num[i];
            }
            float avg = (float)sum / 10;


            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Average is "+ avg);


        }
    }
}
