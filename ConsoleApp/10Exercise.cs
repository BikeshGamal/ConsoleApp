using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _10Exercise
    {
        public static void Main(string[] args) { 
        for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter any number:");
            int num=int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
    }
}
