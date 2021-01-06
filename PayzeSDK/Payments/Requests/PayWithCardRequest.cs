using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Requests
{
    public class PayWithCardRequest : IRequest
    {
        public string Method { get; }
    }
}