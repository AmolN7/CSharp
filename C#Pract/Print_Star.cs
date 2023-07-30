//Print_Star
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Print_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j, num;
            Console.WriteLine("Enter num of rows (1to 10)");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (i <= num)
            {
                j = 1;
                while (j <= i)
                {
                    Console.Write(" * ");
                    j++;
                }
                Console.WriteLine();
                i++;

            } Console.Read();
        }
    }
}
/*
Op
Enter num of rows (1to 10)
10

 *
 *  *
 *  *  *
 *  *  *  *
 *  *  *  *  *
 *  *  *  *  *  *
 *  *  *  *  *  *  *
 *  *  *  *  *  *  *  *
 *  *  *  *  *  *  *  *  *
 *  *  *  *  *  *  *  *  *  *
*/