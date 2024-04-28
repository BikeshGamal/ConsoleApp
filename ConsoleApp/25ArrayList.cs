using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _25ArrayList
    {
        public static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);
            foreach(int i in al)
            {
                Console.WriteLine(i);
            }
            al.Remove(3);
            foreach(int i in al)
            {
                Console.WriteLine(i);
            }
        }
    }
}
