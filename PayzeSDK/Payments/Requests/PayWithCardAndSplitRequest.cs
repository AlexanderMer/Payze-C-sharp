using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Requests
{
    public class PayWithCardAndSplitRequest : IRequest
    {
        public string Method { get; }
    }
}