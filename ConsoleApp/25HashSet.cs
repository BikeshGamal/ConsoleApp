using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _25HashSet
    {
        public static void Main(string[] args)
        {
            HashSet<int> hs=new HashSet<int>();
            hs.Add(1);
            hs.Add(2);
            hs.Add(3);
            hs.Add(4);
            hs.Add(5);
            foreach (int i in hs)
            {
                Console.WriteLine(i);
            }
            hs.Remove(1);
            foreach (int i in hs)
            { Console.WriteLine(i);}
        }
    }
}
