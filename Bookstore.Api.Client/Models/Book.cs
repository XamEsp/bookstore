using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Api.Client.Models
{
    public class Book
    {
        public string BookId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public double ListPrice { get; set; }
    }
}
