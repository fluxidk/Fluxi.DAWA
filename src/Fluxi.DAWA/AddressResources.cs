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

        public async Task<Address> GetAddress(string addressId)
        {
            return await new GetBase<Address>(_apiClient, "adresser", addressId).Execute();
        }

        public SearchBase<Address> SearchAddress()
        {
            return new SearchBase<Address>(_apiClient, "adresser");
        }

        public async Task<AccessAddress> GetAccessAddress(string accessAddressId)
        {
            return await new GetBase<AccessAddress>(_apiClient, "adgangsadresser", accessAddressId).Execute();
        }

        public SearchBase<AccessAddress> SearchAccessAddress()
        {
            return new SearchBase<AccessAddress>(_apiClient, "adgangsadresser");
        }

        public async Task<ZipcodeDetails> GetZipcode(string zipcode)
        {
            return await new GetBase<ZipcodeDetails>(_apiClient, "postnumre", zipcode).Execute();
        }

        public SearchBase<ZipcodeDetails> SearchZipcode()
        {
            return new SearchBase<ZipcodeDetails>(_apiClient, "postnumre");
        }

        public async Task<RoadsegmentDetails> GetRoadsegment(string municipalCode, string roadCode)
        {
            return await new GetBase<RoadsegmentDetails>(_apiClient, "vejstykker", $"{municipalCode}/{roadCode}").Execute();
        }

        public SearchBase<RoadsegmentDetails> SearchRoadsegment()
        {
            return new SearchBase<RoadsegmentDetails>(_apiClient, "vejstykker");
        }
    }
}
