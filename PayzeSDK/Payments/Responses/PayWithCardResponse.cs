using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PayzeSDK.Payments.Abstractions;
using PayzeSDK.Payments.Enums;

namespace PayzeSDK.Payments.Responses
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class PayWithCardResponse : PaymentResponse
    {
        public string TransactionId { get; set; }
        public Transaction TransactionInfo { get; set; }

        public PayWithCardResponse Response
        {
            set
            {
                TransactionId = value.TransactionId;
                TransactionInfo = value.TransactionInfo;
            }
        }
    }
}