using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    internal class Clothing : Product
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public Clothing(string name, double price, string size, string color) : base(name, price)
        {
            Size = size;
            Color = color;
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Clothing Item: {Name}, Size: {Size}, Color: {Color}, Price: ${Price}");
        }

    }
}
