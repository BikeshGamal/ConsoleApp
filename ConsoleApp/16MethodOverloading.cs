using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _16MethodOverloading
    {
        public static void add(int a,int b)
        {
            Console.WriteLine($"sum of {a} and {b}={a + b}");
        }
        public static void add(int a,int b,int c)
        {
            Console.WriteLine($"sum of {a},{b} and {c}={a + b + c}");
        }
        public static void add(double a, double b)
        {
            Console.WriteLine($"sum of {a} and {b}={a + b}");
        }
        public static void Main(string[] args)
        {
            add(5, 5);
            add(10, 20, 30);
            add(45.5,56.7);
        }
    }
}
