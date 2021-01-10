using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Payments.Requests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class GetMerchantBalanceRequest : IPaymentRequest
    {
        public string Method { get; } = "getBalance";
    }
}