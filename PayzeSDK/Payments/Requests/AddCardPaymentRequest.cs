using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Payments.Requests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class AddCardPaymentRequest : IPaymentRequest
    {
        public string Method { get; } = "addCard";

        public string CallbackUrl { get; set; }

        public string CallbackErrorUrl { get; set; }
    }
}