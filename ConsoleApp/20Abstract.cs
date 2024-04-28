using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Shape
    {
        public abstract void area(double l, double b);
        public abstract void perimeter(double l, double b);
        public void show()
        {
            Console.WriteLine("Abstract class Example");
        }
    }
    public class Rectangle : Shape
    {
        public override void area(double l, double b)
        {
            Console.WriteLine($"area of reactangle={l * b}");
        }

        public override void perimeter(double l, double b)
        {
            Console.WriteLine($"perimeter of rectangle={2*(l+b)}");
        }
    }
    internal class _20Abstract
    {
        public static void Main(string[] args)
        {
            Rectangle r1=new Rectangle();
            r1.area(10,6);
            r1.perimeter(10, 6);
            r1.show();
        }
    }
}
