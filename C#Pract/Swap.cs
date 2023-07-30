//Swap
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine(" Enter A");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swap\n"+a+" "+b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap\n"+a+"  "+b);
            Console.Read();

        }
    }
}
/*
O/p
Enter A
12
 Enter B
25
Before Swap
12 25
After Swap
25  12
*/