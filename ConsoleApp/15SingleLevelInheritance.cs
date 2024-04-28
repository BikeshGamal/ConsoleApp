using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Person
    {
        public string name;
        public int age;
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void personInfo()
        {
            Console.WriteLine("Information of Person:");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
        }
    }
    public class Student : Person
    {
        public int sid;
        public Student(int sid,string name,int age) : base(name, age)
        {
            this.sid = sid;
        }
        public void studentInfo()
        {
            Console.WriteLine("Information of Student:");
            Console.WriteLine("Sid:" + sid);
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);
        }
    }
    internal class _15SingleLevelInheritance
    {
        public static void Main(string[] args)
        {
            Student std = new Student(101, "Jyoti Raj Kharel", 23);
            std.personInfo();
            std.studentInfo();
        }
    }
}
