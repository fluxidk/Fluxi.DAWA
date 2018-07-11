using RestSharp;

namespace Fluxi.DAWA
{
    public class DAWAClient
    {
        private IRestClient _apiClient;

        public DAWAClient()
        {
            _apiClient = new RestClient("http://dawa.aws.dk/");
            _apiClient.AddDefaultParameter("noformat", "", ParameterType.QueryString);
        }

        public DAWAClient(IRestClient apiClient)
        {

        }

        public AddressResources Address
        {
            get { return new AddressResources(_apiClient); }
        }

        // ADDRESS

        // ---> AccessAddresses

        // ---> Addresses

        // ---> Roadsegments

        // ---> Roadnames

        // ---> Postcodes

        // ---> OwnerAssociations

        // ---> Lands





        // DAGI

        // ---> Municipalities

        // ---> PoliceAreas

        // ---> Regions

        // ---> Jurisdictions

        // ---> Parish
    }
}
