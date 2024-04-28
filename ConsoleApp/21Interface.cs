using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface Area
    {
        public void area(int l, int b);
    }
    public interface Perimeter
    {
        public void perimeter(int l, int b)
        {
            Console.WriteLine($"Perimeter={2 * (l + b)}");
        }
    }
    public class Rectangle1 : Area, Perimeter
    {
        public void area(int l,int b)
        {
            Console.WriteLine($"area={l * b}");
        }
    }
    internal class _21Interface
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.perimeter(10, 7);
            rectangle.area(10, 7);
        }
    }
}
