using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDb
{
    class NonFictionBook : Book
    {
        public string Topic { get; set; }
        public NonFictionBook(string title, string author, int pages, string topic) : base(title, author, pages)
        {
            Topic = topic;
        }

        public override void GetAdditionalInfo()
        {
            Console.WriteLine($"Topic = {Topic}");
        }
    }
}