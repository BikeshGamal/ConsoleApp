using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
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
        }
    }
}
