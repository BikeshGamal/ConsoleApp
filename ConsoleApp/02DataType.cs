using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _02DataType
    {
        public readonly int x = 89;
        public _02DataType()
        {
            x = 90;
        }
        public static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("a:" + a);
            float b = 3.2f;
            Console.WriteLine("b:" + b);
            double c = 123.456;
            Console.WriteLine("c:" + c);
            char d='a';
            Console.WriteLine("d:" + d);
            string e = "test";
            Console.WriteLine("e:" + e);
            bool f= true;
            Console.WriteLine("f:" + f);
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("date time:" + dateTime);
            var g = 678;
            Console.WriteLine("g:" + g);
            //g = 678.78; error
            dynamic h = 890;
            Console.WriteLine("h:" + h);
            h = "test";
            Console.WriteLine("h:" + h);
            const double pi = 3.14;
            Console.WriteLine("pi:" + pi);
            _02DataType dt = new _02DataType();
            Console.WriteLine(dt.x);
        }
    }
}
