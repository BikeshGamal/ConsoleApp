using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Person1
    {
        public string name;
        public int age;
        public void showInfo()
        {
            Console.WriteLine("Information of Person");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
        }
    }
    internal class _12ClassObjectNamespace
    {
        public static void Main(string[] args)
        {
            Person1 person1 = new Person1();
            person1.name = "Ram Subedi";
            person1.age = 23;
            person1.showInfo();
        }
    }
}
