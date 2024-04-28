using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _25GenricQueue
    {
        public static void Main(string[] args)
        {
            Queue<string> q
                = new Queue<string>();  
            q.Enqueue("Raju Pathak");
            q.Enqueue("Bhaskar Pokhrel");
            q.Enqueue("Subechchya Chaulagain");
            q.Enqueue("Gaurav Khadka");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            q.Dequeue();
            foreach ( var item in q)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
