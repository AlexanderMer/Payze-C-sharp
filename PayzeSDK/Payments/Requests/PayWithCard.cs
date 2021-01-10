using System.Collections.Generic;
using PayzeSDK.Payments.Abstractions;
using PayzeSDK.Payments.Enums;
using PayzeSDK.Payments.Requests.Helpers;

namespace PayzeSDK.Payments.Requests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class PayWithCard : PaymentWithCurrency, IPaymentRequest
    {
       
        public PayWithCard(decimal amount, Currency currency, bool preauthorize, string cardToken, 
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
        
        public bool Preauthorize { get; set; }
        
        public string CardToken { get; set; }

        public List<Split> Splits { get; set; }
    }
}