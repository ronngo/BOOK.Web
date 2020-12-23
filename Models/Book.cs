using System;
using System.Collections.Generic;
using System.Text;

namespace BOOK.Web1.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string NameBook { get; set; }
        public string NameAuthor { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }

        /* public string Int { get; set; }*/


    }
}
