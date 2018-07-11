namespace Fluxi.DAWA.Requests
{
    public enum AccessAddressParam
    {
        [ParameterDescription("q")]
        FreeText,
        [ParameterDescription("etage")]
        Floor,
        [ParameterDescription("dør")]
        Door,
        [ParameterDescription("vejnavn")]
        Roadname,
        [ParameterDescription("husnr")]
        HouseNo,
        [ParameterDescription("postnr")]
        Zipcode,
        [ParameterDescription("kommunekode")]
        MunicipalCode,
        [ParameterDescription("matrikelnr")]
        CadastralNo,
        [ParameterDescription("husnrfra")]
        HouseNoFrom,
        [ParameterDescription("husnrtil")]
        HouseNoTo,
        [ParameterDescription("vejkode")]
        Roadcode
    }
}
