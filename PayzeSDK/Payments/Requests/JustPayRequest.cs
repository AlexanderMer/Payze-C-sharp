using System.Collections.Generic;
using PayzeSDK.Payments.Abstractions;
using PayzeSDK.Payments.Requests.Helpers;

namespace PayzeSDK.Payments.Requests
{
    public class JustPayRequest : IPaymentRequest
    {
        public string Method { get; } = "justPay";
        
        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public string CallbackUrl { get; set; }

        public string CallbackErrorUrl { get; set; }

        public bool Preauthorize { get; set; }
        
        public List<Split> Splits { get; set; }
    }
}