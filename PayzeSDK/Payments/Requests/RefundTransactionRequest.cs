using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Requests
{
    public class RefundTransactionRequest : IRequest
    {
        public string Method { get; }
    }
}