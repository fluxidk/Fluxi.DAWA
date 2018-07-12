using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fluxi.DAWA.Requests
{
    public class GetBase<T> where T : class
    {
        internal IRestClient ApiClient { get; set; }
        internal RestRequest ApiRequest { get; set; }

        public GetBase(IRestClient apiClient, string searchPath, string identifier)
        {
            ApiClient = apiClient;
            ApiRequest = new RestRequest($"/{searchPath}/{identifier}", Method.GET);
        }

        public GetBase()
        {

        }

    }
}
