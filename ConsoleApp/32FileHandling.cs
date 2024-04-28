using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _32FileHandling
    {
        public static void Main(string[] args)
        {
            string fileName = "sample.txt";
            using (StreamWriter SW=new StreamWriter(fileName))
            {
                SW.WriteLine("hello");
            }
            using (StreamReader sr=new StreamReader(fileName))
            {
                string content=sr.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
}
