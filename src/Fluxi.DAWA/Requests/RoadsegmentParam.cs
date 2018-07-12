namespace Fluxi.DAWA.Requests
{
    public enum RoadsegmentParam
    {
        [ParameterDescription("q")]
        FreeText,
        [ParameterDescription("kommunekode")]
        MunicipalCode,
        [ParameterDescription("kode")]
        RoadCode,
        [ParameterDescription("navn")]
        Name,
        [ParameterDescription("postnr")]
        Zipcode
    }
}
