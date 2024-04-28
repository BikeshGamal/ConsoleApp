using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Counter
    {
        public static int count = 0;
        public void counter()
        {
            count++;
        }
        public static void show()
        {
            Console.WriteLine("static method");
        }
    }
    public static class Test
    {
        public static string msg = "you can not create the object of static class";
        public static void show()
        {
            Console.Write(msg);
        }
    }
    internal class _19Static
    {
        public static void Main(string[] args)
        {
            Counter c= new Counter();
            c.counter();
            Console.WriteLine(Counter.count);
            Counter c1=new Counter();
            c1.counter();
            Console.WriteLine(Counter.count);
            Counter.show();
            Console.WriteLine(Test.msg);
            Test.show();
        }
    }
}
