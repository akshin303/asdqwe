using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    internal class Notebook:Product
    {
        public Notebook(string name, int price):base (name,price)
            {

            }
        public Notebook(string name, int price, string ram):base(name,price)
        {
            this.Ram= ram;
        }
        public string Ram;
    }
}
