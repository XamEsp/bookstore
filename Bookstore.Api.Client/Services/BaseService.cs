using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Api.Client.Services
{
    public class BaseService
    {
        public BaseService()
        {
            BaseUrl = new Configuration().Url;
        }

        protected string BaseUrl { get; set; }
    }
}
