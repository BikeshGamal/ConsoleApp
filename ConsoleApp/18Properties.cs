using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Product
    {
        public string name { get; set; }
        private double _price;
        public double price { get { return _price; } set { if (value < 0) { throw new Exception("Price can not be negative"); } else { _price = value; } } }
    }
    internal class _18Properties
    {
        public static void Main(string[] args)
        {
            Product product = new Product();
            product.name = "Phone";
            product.price = -20000;
            Console.WriteLine(product.name);
            Console.WriteLine(product.price);
        }
    }
}
