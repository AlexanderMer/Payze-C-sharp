using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PayzeSDK.Payments.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentStatus
    {
        Blocked,
        CardAdded,
        CardAddedForSubscription,
        CommitFailed,
        Committed,
        Created,
        Nothing,
        Error,
        PlatformReceived,
        Refunded,
        RefundedPartially,
        Rejected,
        Timeout
    }
}