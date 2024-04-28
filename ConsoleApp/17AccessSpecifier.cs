using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _17AccessSpecifier
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("public->can be access from anywhere within a solution");
            Console.WriteLine("private->can be access within a class");
            Console.WriteLine("protected->can be access from class and its child class");
            Console.WriteLine("internal->can be access within a assembly");
            Console.WriteLine("protected internal->can be access within a assembly and can be access from outside assembly using inheritance");
            Console.WriteLine("private protected->can be access from class and its child class");

        }
    }
}
