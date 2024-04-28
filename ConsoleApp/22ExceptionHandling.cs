using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _22ExceptionHandling
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int index;
            Console.WriteLine("Enter any index:");
            index=int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(a[index]);
            }
            catch (IndexOutOfRangeException e){
            Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End of Program");
            }
        }
    }
}
