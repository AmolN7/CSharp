//Print_piryamid
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Print_piryamid
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, m, p, z;
            Console.WriteLine("Enter No. of lines");
            n = Console.Read();
            m=((2*n)-1)/2;
            z = 1;
            for (i = 1; i <= n; i++)
            {
                for (p = 1; p <= m; p++)
                    Console.Write("");
                for (j = 1; j <= z; j++)
                    Console.Write("*");
                m = m - 1;
                z = z + 2;
                Console.WriteLine();

                 Console.Read();

            }
        }
    }
}
/*
OP
Enter No. of lines
3
*
***
*****
*/