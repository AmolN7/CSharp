//Displya_following_pattern
/*Displya Following pattern
 * 1 1 1 1
 * 2 2 2
 * 3 3
 * 4
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Displya_following_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, row=1,col,num;
            Console.WriteLine("Enter  No");
            num = int.Parse(Console.ReadLine());
            col = num;
            for (i = 1; i <= num;i++,row++,col--)
            {
                for (j = 1; j <=col; j++)
                {
                    Console.Write(row);
                    Console.Write("\t");
                }
                Console.WriteLine("\n");
            } Console.Read();

        }
    }
}

