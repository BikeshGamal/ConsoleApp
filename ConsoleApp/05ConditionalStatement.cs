
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _05ConditionalStatement
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any number:");
            num = int.Parse(Console.ReadLine());
            if(num<0)
            {
                Console.WriteLine("the number is negative");
            }
            int num1, num2;
            Console.WriteLine("Enter value of num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of num2:");
            num2= int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else
            {
                Console.WriteLine($"{num2} is greater than {num1}");
            }
            int a, b, c;
            Console.WriteLine("Enter value of a:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b:");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of c:");
            c=int.Parse(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine($"{a} is greatest.");
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine($"b is greatest.");
            }
            else
            {
                Console.WriteLine($"{c} is greatest.");
            }
            int x, y, z;
            Console.WriteLine("Enter value of x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of y:");
            y= int.Parse(Console.ReadLine());   
            Console.WriteLine("Enter the value of z:");
            z = int.Parse(Console.ReadLine());
            if(x>y)
            {
                if(x>z)
                {
                    Console.WriteLine($"{x} is greatest");
                }
                else
                {
                    Console.WriteLine($"{y} is greatest");
                }
            }
            else
            {
                if(y>z)
                {
                    Console.WriteLine($"{y} is greatest");
                }
                else
                {
                    Console.WriteLine($"{z} is greatest");
                }
            }
            int choice;
            double z1, z2;
            bool v = true;
            while (v == true)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Exit");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the first value:");
                z1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second value:");
                z2 = double.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"sum={z1 + z2}");
                        break;
                    case 2:
                        Console.WriteLine($"sub={z1 - z2}");
                        break;
                    case 3:
                        Console.WriteLine("mul:" + (z1 * z2));
                        break;
                    case 4:
                        Console.WriteLine("div={0}", (z1 / z2));
                        break;
                    case 5:
                        v = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option selection");
                        break;
                }
            }

        }
    }
}
