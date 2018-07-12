namespace Fluxi.DAWA.Requests
{
    public enum ZipcodeParam
    {
        [ParameterDescription("q")]
        FreeText,
        [ParameterDescription("nr")]
        No,
        [ParameterDescription("navn")]
        Name,
        [ParameterDescription("kommunekode")]
        MunicipalCode,
    }
}
