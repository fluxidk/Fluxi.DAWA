using RestSharp;

namespace Fluxi.DAWA.Requests
{
    public class SearchBase<T> where T : class
    {
        internal IRestClient ApiClient { get; set; }
        internal RestRequest ApiRequest { get; set; }

        public SearchBase(IRestClient apiClient, string searchPath)
        {
            ApiClient = apiClient;
            ApiRequest = new RestRequest(searchPath, Method.GET);
        }
        
        public SearchBase()
        {

        }
    }
}
