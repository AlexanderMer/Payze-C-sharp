using System.Collections.Generic;
using Newtonsoft.Json;
using PayzeSDK.Payments.Abstractions;
using PayzeSDK.Payments.Enums;

namespace PayzeSDK.Payments.Requests
{
    public class JustPayRequest : IPaymentRequest
    {
        public JustPayRequest(decimal amount, Currency currency, bool preauthorize, string callbackUrl = null, 
            string callbackErrorUrl = null, List<Split> splits = null)
        {
            // Required
            Amount = amount;
            Currency = currency;
            Preauthorize = preauthorize;
            
            // Optional
            CallbackUrl = callbackUrl;
            CallbackErrorUrl = callbackErrorUrl;
        }

        public string Method { get; } = "justPay";
        
        public decimal Amount { get; set; }

        public Currency Currency { get; set; }

        public string CallbackUrl { get; set; }

        public string CallbackErrorUrl { get; set; }

        public bool Preauthorize { get; set; }
        
        public List<Split> Splits { get; set; }
    }
}