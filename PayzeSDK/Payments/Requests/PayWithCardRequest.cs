using System.Collections.Generic;
using Newtonsoft.Json;
using PayzeSDK.Payments.Abstractions;
using PayzeSDK.Payments.Enums;

namespace PayzeSDK.Payments.Requests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class PayWithCardRequest : IPaymentRequest
    {
        public PayWithCardRequest(decimal amount, Currency currency, bool preauthorize, string cardToken, 
            List<Split> splits = null)
        {
            // Required
            Amount = amount;
            Currency = currency;
            Preauthorize = preauthorize;
            CardToken = cardToken;
            
            // Optional
            Splits = splits;
        }

        public string Method { get; } = "payWithCard";
        
        public decimal Amount { get; set; }

        public Currency Currency { get; set; }
        
        public bool Preauthorize { get; set; }
        
        public string CardToken { get; set; }

        public List<Split> Splits { get; set; }
    }
}