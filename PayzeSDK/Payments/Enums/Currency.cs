using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PayzeSDK.Payments.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Currency
    {
        GEL,
        USD
    }
}