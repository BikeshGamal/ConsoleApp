using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Calculator
    {
        public double add(double a,double b)
        {
            return a + b;
        }
        public double sub(double a, double b) { return a - b; }
        public double mul(double a,double b) { return a*b; }
        public double div(double a, double b) { return a / b; }
        public bool isEven(int num)
        {
            if(num%2==0)
                {
                return true;
            }
            return false;
        }
    }
    public class Employee
    {
        public string name;
        public double salary;
        public string dateOfJoining;
        public Employee(string name,double salary,string dateOfJoining) {
        this.name = name;
        this.salary = salary;
        this.dateOfJoining = dateOfJoining;
        }
        public void getEmployeeDetails()
        {
            Console.WriteLine("Information of Employee:");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("date of joining:" + dateOfJoining);
        }
    }
    internal class _14Exercise
    {
        public static void Main(string[] args)
        {
            Employee emp=new Employee("Rasid Khan",45000,"2020-01-02");
            emp.getEmployeeDetails();
            Calculator calc=new Calculator();
            Console.WriteLine("sum=" + calc.add(2, 3));
            Console.WriteLine("sub=" + calc.sub(2, 3));
            Console.WriteLine("mul="+calc.mul(2, 3));   
            Console.WriteLine("div="+calc.div(2, 3));
            Console.WriteLine(calc.isEven(39));
        }
    }
}
