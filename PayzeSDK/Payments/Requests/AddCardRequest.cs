using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Requests
{
    public class AddCardRequest : IRequest
    {
        public string Method { get; } = "addCard";

        public string CallbackUrl { get; set; }

        public string CallbackErrorUrl { get; set; }
    }
}