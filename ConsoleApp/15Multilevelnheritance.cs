using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Person3
    {
        public string name;
        public int age;
        public Person3(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void showPerson()
        {
            Console.WriteLine("Information of person:");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);

        }
    }
    public class Student1:Person3
    {
        public int sid;
        public Student1(int sid,string name,int age):base(name,age)
        {
            this.sid = sid;
        }
        public void showStudent()
        {
            Console.WriteLine("Information of student:");
            Console.WriteLine("sid:" + sid);
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);
        }
    }
    public class CollegeStudent : Student1
    {
        public int cid;
        public CollegeStudent(int cid,int sid,string name,int age) : base(sid, name, age)
        {
            this.cid = cid;
        }
        public void showCStudent()
        {
            Console.WriteLine("Information of college student:");
            Console.WriteLine("cid:" + cid);
            Console.WriteLine("sid:" + sid);
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);

        }
    }
    internal class _15Multilevelnheritance
    {
        public static void Main(string[] args)
        {
            CollegeStudent cs = new CollegeStudent(101, 201, "Raju Lama", 23);
            cs.showPerson();
            cs.showStudent();
            cs.showCStudent();
        }
    }
}
