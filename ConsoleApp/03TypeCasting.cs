using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _03TypeCasting
    {
        public static void Main(string[] args)
        {
            int a = 67;
            double b = a;//implicit type casting
            double c = 4567.678;
            int d = (int)c;//explicit type casting
            Console.WriteLine(a);   
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
