using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varuautomat
{
    class Item
    {
        
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public bool Stock { get; set; }

        

    }
    class Food : Item
    {
        public Food (string product, double price, string type, bool stock)
        {
            ProductName = product;
            Price = price;
            Type = type;
            Stock = stock;
        }
        

    }
    class Beverage : Item
    {
        public Beverage(string product, double price, string type, bool stock)
        {
            ProductName = product;
            Price = price;
            Type = type;
            Stock = stock;
            
        }
    }
    class Snacks : Item
    {
        public Snacks(string product, double price, string type, bool stock)
        {
            ProductName = product;
            Price = price;
            Type = type;
            Stock = stock;
        }
    }

    
}
