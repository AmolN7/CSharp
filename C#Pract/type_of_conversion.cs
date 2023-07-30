//type_of_conversion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace type_of_conversion////////i.e. implicite(no information loss)And explicite(information loss)
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 123456;
            long y = x;//implicite
            short z = (short)x;//explicite


            double d = 1.25458454657966;
            float f = (float)d;//expliciet
            long l = (long)d;//explicite


            Console.WriteLine("X="+x+"\nY="+y+"\nZ="+z+"\nD="+d+"\nf="+f+"\nl="+l);
            Console.Read();

        }
    }
}

/*OP
X=123456
Y=123456
Z=-7616
D=1.25458454657966
f=1.254585
l=1
*/ 

