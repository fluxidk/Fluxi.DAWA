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

            //dawa.Address.GetAddress("0a3f509f-4cd7-32b8-e044-0003ba298018").Wait();

            dawa.Address.SearchAccessAddress()
                .AddParameter(AccessAddressParam.Roadname, "Søndergade")
                .AddParameter(AccessAddressParam.Zipcode, "8670")
                .Execute()
                .Wait();
        }
    }
}
