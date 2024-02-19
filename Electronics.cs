using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    internal class Electronics : Product
    {
        public string Brand { get; set; }

        public Electronics(string name, double price, string brand) : base(name, price)
        {
            Brand = brand;
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Grocery Item: {Name}, Brand: {Brand}, Price: ${Price}");
        }
    }
}
