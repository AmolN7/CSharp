//Displya_pattern_1
/*
 * 24680
 * 2468
 * 246
 * 24
 * 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Displya_pattern_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, num,row,col,sum=0;
            Console.WriteLine("Enter no of row(1-5)");
            num = Console.Read();
            col = 5;
            row = num;
            for (i = 0; i<=row;i++,col--)
            {
                
                sum = sum + 2;
                for (j =1; j<sum; j++)
                {
                    
                    Console.Write(sum*2);
                    
                }
                
                j++;

               
                Console.Read();
            }
        }
    }
}

