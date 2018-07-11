using Fluxi.DAWA.Models;
using Fluxi.DAWA.Requests;
using RestSharp;
using System.Threading.Tasks;

namespace Fluxi.DAWA
{
    public class AddressResources
    {
        private IRestClient _apiClient;

        public AddressResources(IRestClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<Address> GetAddress(string id)
        {
            var request = new RestRequest($"/adresser/{id}");
            var response = await _apiClient.ExecuteTaskAsync<Address>(request);

            return response.Data;
        }

        public SearchBase<Address> SearchAddress()
        {
            return new SearchBase<Address>(_apiClient, new RestRequest("/adresser"));
        }

        public async Task<AccessAddress> GetAccessAddress(string id)
        {
            var request = new RestRequest($"/adgangsadresser/{id}");
            var response = await _apiClient.ExecuteTaskAsync<AccessAddress>(request);

            return response.Data;
        }

        public SearchBase<AccessAddress> SearchAccessAddress()
        {
            return new SearchBase<AccessAddress>(_apiClient, new RestRequest("/adgangsadresser"));
        }
    }
}
