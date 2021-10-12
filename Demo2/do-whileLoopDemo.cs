using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    class do_whileLoopDemo
    {
        static void Main()
        {
            int i = 100;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }
    }
}
