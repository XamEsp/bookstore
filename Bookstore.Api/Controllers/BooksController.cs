using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Dal.Domain;
using Bookstore.Dal.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Api.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class BooksController : ControllerBase
   {
      private BookRepository _bookRepository;

      public BooksController()
      {
         _bookRepository = new BookRepository();
      }

      [HttpGet]
      public ActionResult<IEnumerable<Book>> Get()
      {
         var books = _bookRepository.GetBooks();
         return new ActionResult<IEnumerable<Book>>(books);
      }

      [HttpGet("{bookId}")]
      public ActionResult<Book> Get(string bookId)
      {
         return new ActionResult<Book>(_bookRepository.Get(bookId));
      }

      [HttpPost]
      public void Post([FromBody] Book book)
      {
         _bookRepository.Insert(book);
      }

      [HttpPut]
      public void Put([FromBody] Book book)
      {
         _bookRepository.Update(book);
      }

      [HttpDelete("{bookId}")]
      public void Delete(string bookId)
      {
         _bookRepository.Delete(bookId);
      }
   }
}