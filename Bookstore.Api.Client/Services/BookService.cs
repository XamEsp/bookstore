using System.Collections.Generic;
using System.Threading.Tasks;
using Bookstore.Api.Client.Models;
using RestSharp;

namespace Bookstore.Api.Client.Services
{
    public class BookService : BaseService
    {
        private const string Resource = "books";
        public async Task<IEnumerable<Book>> Get()
        {
            var client = new RestClient(BaseUrl);

            var request = new RestRequest(Resource, DataFormat.Json);

            var response = await client.GetAsync<IEnumerable<Book>>(request);

            return response;
        }
        public async Task Insert(Book bookToInsert)
        {
            var client = new RestClient(BaseUrl);

            var request = new RestRequest(Resource, DataFormat.Json);
            request.AddJsonBody(bookToInsert);

            var response = await client.PostAsync<Book>(request);



        }
        // TODO: use a generic response as base for all responses
    }

}
