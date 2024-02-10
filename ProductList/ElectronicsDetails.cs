using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductList
{
    public class ElectronicsDetails
    {
        public string Brand { get; set; }
        public double Price { get; set; }
        public ElectronicsDetails(string brand, double price) 
        {
            Brand = brand;
            Price = price;
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, Price: {Price}";
        }
    }
}