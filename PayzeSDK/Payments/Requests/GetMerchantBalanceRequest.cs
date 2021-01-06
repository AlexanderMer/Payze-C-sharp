using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Requests
{
    public class GetMerchantBalanceRequest : IRequest
    {
        public string Method { get; }
    }
}