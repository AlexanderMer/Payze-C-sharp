using System;

namespace PayzeSDK.Payments.Responses
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class TransactionResponse
    {
        public string TransactionUrl { get; set; }
        
        public string TransactionId { get; set; }
    }

    // ReSharper disable once ClassNeverInstantiated.Global
    public class JustPayResponse
    {
        public string TransactionUrl { get; private set; }

        public string TransactionId { get; private set; }

        public TransactionResponse Response
        {
            set
            {
                TransactionUrl = value.TransactionUrl;
                TransactionId = value.TransactionId;
            }
        }
    }
}