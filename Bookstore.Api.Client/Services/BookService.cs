using System.Collections.Generic;
using System.Threading.Tasks;
using Bookstore.Api.Client.Models;
using RestSharp;

namespace Bookstore.Api.Client.Services
{
    public class BookService : BaseService
    {
        public async Task<IEnumerable<Book>> Get()
        {
            var client = new RestClient(BaseUrl);

            var request = new RestRequest("books", DataFormat.Json);

            var response = await client.GetAsync<IEnumerable<Book>>(request);

            return response;
        }
    }

}
