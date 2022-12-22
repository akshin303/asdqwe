using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    internal class Product
    {
        public Product(string name,int Price) 
        { 
            this.Name = name;
            this.Price = Price;
        }
        public string GetInfo()
        {
            return $"Name:{Name}- Price:{Price} ";
        }
        public string Name;
        public int Price;
    }
}
