using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PayzeSDK.Payments.Abstractions;
using PayzeSDK.Payments.Enums;

namespace PayzeSDK.Payments.Responses
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class TransactionInfo : PaymentResponse
    {
        public string CardMask { get; set; }
        
        public decimal Amount { get; set; }
        
        public bool GetCanBeCommitted { get; set; }
        
        public string ResultCode { get; set; }
        
        public string TransactionId { get; set; }
        
        public DateTime CommitDate { get; set; }
        
        public decimal FinalAmount { get; set; }
        
        public Currency Currency { get; set; }
        
        public decimal Commission { get; set; }
        
        public bool Refundable { get; set; }
        
        public decimal Refunded { get; set; }
        
        public PaymentStatus Status { get; set; }
        
        public DateTime CreateDate { get; set; }
    }

    // ReSharper disable once ClassNeverInstantiated.Global
    public class PayWithCardResponse : PaymentResponse
    {
        public string TransactionId { get; set; }
        public TransactionInfo TransactionInfo { get; set; }

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