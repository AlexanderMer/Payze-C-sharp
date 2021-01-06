using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Requests
{
    public class CommitTransactionRequest : IRequest
    {
        public string Method { get; }
    }
}