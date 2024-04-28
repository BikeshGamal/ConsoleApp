using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Extension
    {
        public static bool isEven(this int n)
        {
            if(n%2==0)
            {
                return true;

            }
            return false;
        }
    }
    internal class _26ExtensionMethod
    {
        public static void Main(string[] args)
        {
            int n = 30;
            Console.Write(n.isEven());
        }
    }
}
