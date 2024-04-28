using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _31recursion
    {
        public static void show(int n)
        {
            if(n<=10)
            {
                Console.WriteLine(n);
                show(n + 1);
            }
        }
        public static int fact(int n)
        {
            if(n==0)
            {
                return 1;
            }
            else
            {
                return n * fact(n - 1);
            }
        }
        public static int  fibo(int n)
        {
            if(n<=1)
            {
                return n;
            }
            else
            {
                return fibo(n - 1) + fibo(n - 2);
            }
        }
        public static void Main(string[] args)
        {
            show(1);
            Console.WriteLine(fact(5));
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine(fibo(i));
            }
        }
    }
}
