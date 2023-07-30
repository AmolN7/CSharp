//DecimalTo_octal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalTo_octal
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum, rem, temp, x;
            Console.WriteLine("Enter decimal No.");
            num = int.Parse(Console.ReadLine());
            sum = 0;
            temp = 1;
            x = num;
            while (num > 0)
            {
                rem = num % 8;
                sum = sum + rem * temp;
                num = num / 8;
                temp = temp * 10;
            }
            Console.WriteLine("The Octal Equivalenrt Decimal no"+sum);
            Console.Read();
        }
    }
}

/*O/P

Enter decimal No.
251
The Octal Equivalenrt Decimal no    373
*/
