using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Person2 {
        public string name;
        public int age;
        public Person2() {
            Console.WriteLine("This is the example of default constructor");
        }
        public Person2(string name,int age) {
            this.name = name;
            this.age = age;
        }
        public void showPerson()
        {
            Console.WriteLine("Information of person:");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:"+age);
        }
    }
    internal class _13Constructor
    {
        public static void Main(string[] args)
        {
            Person2 person = new Person2();
            person.showPerson();
            Person2 person2 = new Person2("Rahul Khadka",23);
            person2.showPerson();
        }
    }
}
