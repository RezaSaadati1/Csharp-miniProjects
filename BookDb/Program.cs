using System;

namespace BookDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] libraryCatalog = new Book[]
            {
                new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", 180, "Classic"),
                new FictionBook("Dune", "Frank Herbert", 412, "Science Fiction"),
                new NonFictionBook("sdgvsdv", "Yuval Noha Harari", 512, "History"),
                new NonFictionBook("Atomic Hobits", "James Clear", 320, "Self-Help"),

            };

            Console.Clear();
            Library.DisplayBook(libraryCatalog);
        }
    }

}
