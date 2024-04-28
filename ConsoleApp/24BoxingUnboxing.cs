using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _24BoxingUnboxing
    {
        public static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("a:"+a);
            object o = a;
            Console.WriteLine("o:"+o);
            int b = (int)o;
            Console.WriteLine("b:"+b);
        }
    }
}
