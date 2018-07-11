using RestSharp;

namespace Fluxi.DAWA.Requests
{
    public class SearchBase<T> where T : class
    {
        internal IRestClient ApiClient { get; set; }
        internal RestRequest ApiRequest { get; set; }

        public SearchBase(IRestClient apiClient, RestRequest apiRequest)
        {
            ApiClient = apiClient;
            ApiRequest = apiRequest;
        }

        public SearchBase()
        {

        }
    }
}
