using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _30AnonymousFunction
    {
        public static Func<int, int, int> add = (a, b) => a + b;
        public static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("sum=" + add(10, 20));
        }
    }
}
