using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void DisplayProductInfo()
        {
            Console.WriteLine("Product Information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
        }

    }
}
