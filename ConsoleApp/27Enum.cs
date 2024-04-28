using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _27Enum
    {
        public enum day {sunday,monday,tuesday,wednesday,thursday,friday,saturday }
        public static void Main(string[] args)
        {
            Console.WriteLine(day.sunday);  
            Console.WriteLine(day.monday);
            Console.WriteLine(day.tuesday);
            Console.WriteLine(day.wednesday);
            Console.WriteLine(day.thursday);
            Console.WriteLine(day.friday);
            Console.WriteLine(day.saturday);
        }
    }
}
