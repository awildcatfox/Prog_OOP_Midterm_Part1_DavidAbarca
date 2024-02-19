using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


            

        protected Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void DisplayProductInfo(); 
     
    }
}
