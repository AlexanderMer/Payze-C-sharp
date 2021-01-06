using System;
using PayzeSDK.Requests;

namespace PayzeSDK.Payments.Responses
{
    public class TransactionResponse
    {
        public string TransactionUrl { get; set; }
        
        public string TransactionId { get; set; }
    }
    
    public class JustPayResponse
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public string Action { get; set; }

        public DateTime CreatedDate { get; set; }

        public JustPayRequest Request { get; set; }

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