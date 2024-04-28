using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _04Operator
    {
        public static void Main(string[] args)
        {
            int a=10, b = 20;
            Console.WriteLine($"sum={a + b}");
            Console.WriteLine($"sub={a-b}");
            Console.WriteLine($"mul={a * b}");
            Console.WriteLine($"div={a / b}");
            Console.WriteLine($"modulo div={a % b}");
            Console.WriteLine($"post increment={a++}");
            Console.WriteLine($"pre increment={++a}");
            Console.WriteLine($"post decrement={a--}");
            Console.WriteLine($"pre decrement={--a}");
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            double x = 7;
            Console.WriteLine(x);
            x += 5;
            Console.WriteLine(x);
            x -= 6;
            Console.WriteLine(x);
            x *= 8;
            Console.WriteLine(x);
            x /= 9;
            Console.WriteLine(x);
            x %=3;
            Console.WriteLine(x);
            Console.WriteLine((a>7)&&(a<23));
            Console.WriteLine((a > 7) || (a < 23));
            Console.WriteLine(!(a > 7));
        }
    }
}
