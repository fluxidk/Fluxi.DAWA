using Fluxi.DAWA;
using Fluxi.DAWA.Requests;
using System;

namespace NetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var dawa = new DAWAClient();

            //dawa.Address.GetAddress("0a3f50c2-25c4-32b8-e044-0003ba298018").Wait();

            //dawa.Address.SearchAccessAddress()
            //    .AddParameter(AccessAddressParam.Roadname, "Danmarksvej")
            //    .AddParameter(AccessAddressParam.HouseNo, "26")
            //    .AddParameter(AccessAddressParam.Zipcode, "8660")
            //    .Execute()
            //    .Wait();

            var kk = dawa.Address.GetRoadsegment("0101", "316").Result;

            var qqq = dawa.Address.SearchRoadsegment()
                .AddParameter(RoadsegmentParam.Name, "Søndergade")
                .AddParameter(RoadsegmentParam.Zipcode, "8670")
                .Execute()
                .Result;
        }
    }
}
