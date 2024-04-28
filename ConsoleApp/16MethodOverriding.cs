using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Parent
    {
        public virtual void show(string message)
        { 
            Console.WriteLine("Parent Message:"+message);
        }
    }
    public class Child : Parent
    {
        public override void show(string message)
        {
            Console.WriteLine("Child Message:" + message);
        }
    }
    internal class _16MethodOverriding
    {
        public static void Main(string[] args)
        {
            Child child = new Child();
            child.show("Hello");
            Parent parent = new Parent();
            parent.show("hello");
        }
    }
}
