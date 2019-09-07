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

      // GET api/values
      [HttpGet]
      public ActionResult<IEnumerable<Book>> Get()
      {
         var books = _bookRepository.GetBooks();
         return new ActionResult<IEnumerable<Book>>(books);
      }

      // GET api/values/5
      [HttpGet("{id}")]
      public ActionResult<string> Get(int id)
      {
         return "value";
      }

      // POST api/values
      [HttpPost]
      public void Post([FromBody] Book book)
      {
         _bookRepository.Insert(book);
      }

      // PUT api/values/5
      [HttpPut("{id}")]
      public void Put(int id, [FromBody] string value)
      {
      }

      // DELETE api/values/5
      [HttpDelete("{id}")]
      public void Delete(int id)
      {
      }
   }
}
