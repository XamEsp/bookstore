using System;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Api.Client.Models;
using NUnit.Framework;

namespace Bookstore.Api.Client.Test
{
    public class BookServiceTestFixture : BaseServiceTestFixture
    {
        [Test]
        public async Task NewDbIsEmptyTest()
        {
            // Arrange
            var booksService = GetBooksService();

            // Act
            var books = await booksService.Get();

            // Assert
            Assert.That(books?.Count() ?? -1, Is.EqualTo(0));
        }

        [Test]
        public async Task CreateBookTest()
        {
            // Arrange
            var booksService = GetBooksService();
            var book = new Book
            {
                BookId = "556bbdd0-e7ca-4c13-bdd0-7271c1a8de21",
                Title = "Programming C#",
                ISBN = "0596001177"
            };

            // Act
            await booksService.Insert(book);

            // Assert
            var books = await booksService.Get();
            Assert.That(books?.Count() ?? -1, Is.EqualTo(1));
        }
    }
}