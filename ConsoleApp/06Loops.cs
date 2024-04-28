using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _06Loops
    {
        public static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            int j = 1;
            while(j<=10)
            {
                Console.WriteLine(j);
                j++;
            }
            int k = 1;
            do
            {
                Console.WriteLine(k);
                k++;
            }while(k<=10);
            int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
