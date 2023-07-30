//reverce_dig_integer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reverce_dig_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp;
            Console.WriteLine("Enter Any Integer Value");
            num = int.Parse(Console.ReadLine());
            do
            {
                temp = num % 10;
                Console.Write(temp);
                num = num / 10;
            }
            while (num != 0);
            Console.Read();
        }
       


    }
}
/*
OP
Enter Any Integer Value
1452
2541
*/