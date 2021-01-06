using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Requests
{
    public class GetTransactionInformationRequest : IRequest
    {
        public string Method { get; }
    }
}