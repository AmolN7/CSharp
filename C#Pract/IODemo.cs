//IODemo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int rollno;
            Console.WriteLine("Plase Enter your Name...!");
            name = Console.ReadLine();
            Console.WriteLine("Plase Enter your Roll No...!");
            rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Thanks...!");
            Console.WriteLine("your Name is" + name);
            Console.WriteLine("your Roll No is" + rollno);
            Console.WriteLine("your NAME is{0}{1}",name+"\nyour Roll No is",rollno);
            Console.ReadLine();
        }
        
    }
}
/*
OP
Plase Enter your Name...!
AMOL
Plase Enter your Roll No...!
17
Thanks...!
your Name isAMOL
your Roll No is17
your NAME isAMOL
your Roll No is17
*/