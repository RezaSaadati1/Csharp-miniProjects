using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDb
{
    abstract class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
       
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public abstract void GetAdditionalInfo();

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Title = {Title}");
            Console.WriteLine($"Author = {Author}");
            Console.WriteLine($"Pages = {Pages}");
        }

    }
}