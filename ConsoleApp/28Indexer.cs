using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Fruits
    {
        public string[] fruit = new string[5];
        public string this[int index] { get { return fruit[index]; }set { fruit[index] = value; } }
    }
    internal class _28Indexer
    {
        public static void Main(string[] args)
        {
            Fruits fruits = new Fruits();
            fruits[0] = "Apple";
            fruits[1] = "Banana";
            fruits[2] = "Mango";
            fruits[3] = "Grapes";
            fruits[4] = "Orange";
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}
