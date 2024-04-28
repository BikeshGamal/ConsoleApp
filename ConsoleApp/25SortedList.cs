using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _25SortedList
    {
        public static void Main(string[] args)
        {
            SortedList<string,dynamic> sl=new SortedList<string, dynamic> ();
            sl.Add("name", "Rajan");
            sl.Add("address", "KTM");
            sl.Add("age", 24);
            foreach(var item in sl)
            {
                Console.WriteLine(item);    
            }
            sl.Remove("age");
            foreach(var item in sl)
            {
                Console.WriteLine (item);
            }
        }
    }
}
