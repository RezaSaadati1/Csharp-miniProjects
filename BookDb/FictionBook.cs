using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDb
{
    class FictionBook : Book
    {
        public string Genre { get; set; }
        public FictionBook(string title, string author, int pages, string genre) : base(title, author, pages)
        {
            Genre = genre;
        }

        public override void GetAdditionalInfo()
        {
            Console.WriteLine($"Genre = {Genre}");

        }
    }
}