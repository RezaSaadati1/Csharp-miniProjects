using System;
using System.Collections.Generic;

namespace ProductList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product<object>> inventory = new List<Product<object>>
            {
                new Product<object> ("Laptop",ProductCategory.Electronic, new ElectronicsDetails("Dell", 988.99)),
                new Product<object> ("T-Shirt",ProductCategory.Clothing, new ClothingDetails("Medium", "Cotton")),
                new Product<object> ("Book",ProductCategory.Books, "Introduction to C# programing"),
                new Product<object> ("Apple",ProductCategory.Food, "Red Delicious")
            };

            foreach(var Product in inventory)
            {
                Console.WriteLine("-----------");
                Product.DisplayInfo();
                Console.WriteLine("-----------");

            }
        }
    }
}
