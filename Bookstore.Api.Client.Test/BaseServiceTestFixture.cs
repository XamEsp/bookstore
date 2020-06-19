using System.IO;
using Bookstore.Api.Client.Services;
using NUnit.Framework;

namespace Bookstore.Api.Client.Test
{
    public class BaseServiceTestFixture
    {
        protected BookService GetBooksService(bool keepDb = false)
        {
            InitDb(keepDb);
            return new BookService();
        }

        private static void InitDb(bool keepDb)
        {
            if (!keepDb)
            {
                // Delete database
                var dbPath =
                    @"C:\Desarrollo\@Samples\Bookstore\Bookstore.Api\Bookstore.db"; // replace with your local db file location
                if (File.Exists(dbPath))
                {
                    File.Delete(dbPath);
                    Assert.False(File.Exists(dbPath));
                }
            }

            // Set configuration
            Configuration.Environment = Env.Custom;
            Configuration.CustomUrl = "https://localhost:44332/api/"; // replace with your local url for tests
        }
    }
}