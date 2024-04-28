using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _09Exercise
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the value of a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of c:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication of {a},{b} and {c}={a * b * c}");
            int num1, num2;
            Console.WriteLine("Enter the value of num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of num2:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Average of {num1} and {num2}={(num1 + num2) / 2}");
            Console.WriteLine("Enter the positive value:");
            int pos=int.Parse(Console.ReadLine());  
            if(pos <0) {
                Console.WriteLine("we do not accept negative value");
            }
            else
            {
                Console.WriteLine(
                    $"the positive value={pos}");
            }
            for(int i = 0; i < 4; i++) {
                Console.WriteLine("**");
            }
            string name = "JOHN DOE";
            Console.WriteLine("length of name=" + name.Length);
            for (int i = 1; i <= 10; i++) 
            {
                if(i==6)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
