using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _29Delegate
    {
        public delegate int Calc(int a, int b);
        public static int add(int a,int b)
        {
            return a + b;
        }
        public static int sub(int a,int b)
        {
            return a - b;
        }
        public static void Main(string[] args)
        {
            Calc c;
            c = add;
            Console.WriteLine("sum ="+c(10,20));
            c = sub;
            Console.WriteLine("sub=" + c(10, 20));
        }
    }
}
