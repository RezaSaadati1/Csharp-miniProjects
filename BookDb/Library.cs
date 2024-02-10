using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDb
{
    class Library
    {
        public static void DisplayBook(Book[] books)
        {
            foreach(var book in books)
            {
                Console.WriteLine("----------");
                book.DisplayBasicInfo();
                book.GetAdditionalInfo();
                Console.WriteLine("----------");

            }

        } 
    }
}