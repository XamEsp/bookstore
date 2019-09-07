using System;
using System.Collections.Generic;

namespace Bookstore.Dal.Domain
{
   public class Book
   {
      public Book()
      {
         BookId = Guid.NewGuid().ToString();
      }

      public string BookId { get; set; }
      public string ISBN { get; set; }
      public string Title { get; set; }
      public List<Author> Authors { get; set; }
      public double ListPrice { get; set; }
   }
}