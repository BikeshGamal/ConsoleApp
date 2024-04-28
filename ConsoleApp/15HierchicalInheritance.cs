using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Person4
    {
        public string name;
        public int age;
        public Person4(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void showPerson()
        {
            Console.WriteLine("Information of Person:");
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);
        }
    }
    public class Student2:Person4
    {
        public int sid;
        public Student2(int sid,string name,int age) : base(name, age)
        {
            this.sid = sid;
        }
        public void shoeStudent()
        {
            Console.WriteLine("Information of student:");
            Console.WriteLine("sid:" + sid);
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);
        }
    }
    public class Teacher : Person4
    {
        public int tid;
        public Teacher(int tid,string name,int age):base(name,age)
        {
            this.tid = tid;
        }
        public void showTeacher()
        {
            Console.WriteLine("Information of Teacher:");
            Console.WriteLine("tid:" + tid);
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);
        }
    }
    internal class _15HierchicalInheritance
    {
        public static void Main(string[] args)
        {
            Student2 std = new Student2(101, "Sujit Pathak", 29);
            std.showPerson();
            std.shoeStudent();
            Teacher t = new Teacher(201, "Rajesh Kushwaha", 45);
            t.showPerson();
            t.showTeacher();
        }
    }
}
