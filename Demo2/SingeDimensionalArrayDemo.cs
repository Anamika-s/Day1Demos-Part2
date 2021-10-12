using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    class SingeDimensionalArrayDemo
    {
        // Take 10 numbers & display them
       static void Main()
        {
            int[] num = new int[10];
            Console.WriteLine("Enter Numbers");
            for(int i=0;i<10; i++)
            {
                num[i] = Convert.ToByte(Console.ReadLine());

            }

            Console.WriteLine("Numbers are ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num[i]);
            }

            }
    }
}
