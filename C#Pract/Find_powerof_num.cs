

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_powerof_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i,power,mult=1;
            Console.WriteLine("Enter No");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter power");
            power = int.Parse(Console.ReadLine());
            for(i=1;i<=power;i++)
            {
                mult = mult * num;
            } 
            Console.Write(mult);
            Console.Read();
            
            
        }
    }
}

/*
OP

Enter No
25
Enter power
25
1296002393
*/