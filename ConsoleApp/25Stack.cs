using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _25Stack
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
                
            stack.Push(5);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();
            foreach (var item in stack)
            { Console.WriteLine(item); }    
        }
    }
}
