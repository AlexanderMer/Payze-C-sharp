using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Payments.Requests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class AddCardRequest : IPaymentRequest
    {
        public AddCardRequest(string callbackUrl = null, string callbackErrorUrl = null)
        {
            // optional
            CallbackUrl = callbackUrl;
            CallbackErrorUrl = callbackErrorUrl;
        }

        public string Method { get; } = "addCard";

        public string CallbackUrl { get; set; }

        public string CallbackErrorUrl { get; set; }
    }
}