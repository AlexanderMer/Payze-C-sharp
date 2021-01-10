using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PayzeSDK.Payments.Enums;

namespace PayzeSDK.Payments.Abstractions
{
    public abstract class PaymentWithCurrency
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Currency Currency { get; set; }
    }
}