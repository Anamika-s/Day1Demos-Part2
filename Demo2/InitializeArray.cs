using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    class InitializeArray
    { 

 
         // Take 10 numbers & display their sum & average
            static void Main()
            {
            // Declare & Initialize Array
                int[] num = new int[] { 1, 2, 3, 4 };
                int sum = 0;
                
                for (int i = 0; i < num.Length; i++)
                {
                   sum += num[i];
                }
                float avg = (float)sum / 10;


                Console.WriteLine("Sum is " + sum);
                Console.WriteLine("Average is " + avg);


            }
        }
    }

 