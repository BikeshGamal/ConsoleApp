using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _25HashTable
    {
        public static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("name", "Basnata pokhrel");
            hashtable.Add("address", "Kathmandu");
            hashtable.Add("id", 1234);
            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }
            hashtable.Remove("address");
            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }
        }
    }
}
