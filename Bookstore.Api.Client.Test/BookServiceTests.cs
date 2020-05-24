using System.Linq;
using System.Threading.Tasks;
using Bookstore.Api.Client.Services;
using NUnit.Framework;

namespace Bookstore.Api.Client.Test
{
    public class BookServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetOkTest()
        {
            // Arrange
            Configuration.Environment = Env.Prod;
            var booksService = new BookService();

            // Act
            var books = await booksService.Get();

            // Assert
            Assert.That(books?.Count() ?? 0, Is.GreaterThan(0));
        }
    }
}