using System.Collections.Generic;
using Bookstore.Dal.Domain;
using LiteDB;

namespace Bookstore.Dal.Repository
{
   public class BookRepository
   {
      private readonly LiteDatabase _db;
      public BookRepository()
      {
         _db = new LiteDatabase("bookstore.db");
         Books.EnsureIndex(x => x.BookId);
      }
      public LiteCollection<Book> Books => _db.GetCollection<Book>();

      public IEnumerable<Book> GetBooks()
      {
         return Books.FindAll();
      }

      public void Insert(Book book)
      {
         Books.Insert(book);
      }

      public void Update(Book book)
      {
         Books.Update(book);
      }

      public bool Delete(string bookId)
      {
         return Books.Delete(bookId);
      }

      public Book Get(string bookId)
      {
         return Books.FindById(bookId);
      }
   }
}
