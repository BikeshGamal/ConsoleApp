using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _08String
    {
        public static void Main(string[] args)
        {
            string str = "testing";
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine($"str={str}");
            string ms = @"hello
I 
am 
from
Chitlang";
            Console.WriteLine(ms);
            string str1 = "test";
            string str2 = string.Concat(str, str1);
            Console.WriteLine(str2);
            str2 = str + str1;
            Console.WriteLine(str2);
            Console.WriteLine(ms.ToUpper());    
        }
    }
}
