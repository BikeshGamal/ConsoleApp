using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _07JumpingStatement
    {
        public static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                if(i==5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            for(int i=1;i<=10;i++)
            {
                if(i==5)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Label:
            Console.WriteLine("Enter positive number:");
            int p=int.Parse(Console.ReadLine()); 
            if(p<0)
            {
                goto Label;
            }
            else
            {
                Console.WriteLine("positive number={0}",p);
            }
        }
    }
}
