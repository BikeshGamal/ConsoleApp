using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _25Dictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<String,dynamic> dc=new Dictionary<String,dynamic>();
            dc.Add("name","Ram");
            dc.Add("address", "KTM");
            dc.Add("age", 23);
            foreach(var item in dc)
            {
                Console.WriteLine(item);    
            }
            dc.Remove("age");
            foreach(var item in dc)
            {
               Console.WriteLine(item);
            }
        }
    }
}
