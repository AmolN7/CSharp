//printStar_decrisingly

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printStar_decrisingly
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,row, col;
            Console.WriteLine("inpute the no of rows");
            row = int.Parse(Console.ReadLine());

            Console.WriteLine("inpute the no of cols");
            col = int.Parse(Console.ReadLine());
            for (i = 0; i < row; i++, col--)
            {
                for (j = 0; j <= col;j++)
                {
                    Console.Write("* \t");
                } Console.WriteLine("\n\n");
            } Console.Read();
        }
    }
}

/*
O/P
inpute the no of rows    5
inpute the no of cols      4
*       *       *       *       *
*       *       *       *
*       *       *
*       *
*
*/