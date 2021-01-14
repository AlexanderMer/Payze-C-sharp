using System;
using System.Collections.Generic;
using PayzeSDK.Payments.Abstractions;
using PayzeSDK.Payments.Enums;
using PayzeSDK.Payments.Responses.Helpers;

namespace PayzeSDK.Payments.Responses
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class GetTransactionInformationResponse : PaymentResponse
    {
        public decimal Amount { get; set; }
        public List<TransactionLog> Log { get; set; }
        public decimal FinalAmount { get; set; }
        public bool GetCanBeCommitted { get; set; }
        public Currency Currency { get; set; }
        public decimal Commission { get; set; }
        public bool Refundable { get; set; }
        public decimal Refunded { get; set; }
        public bool HasSplit { get; set; }
        public string TransactionId { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime CreateDate { get; set; }

        public GetTransactionInformationResponse Response
        {
            set
            {
                Amount = value.Amount;
                Log = value.Log;
                FinalAmount = value.FinalAmount;
                GetCanBeCommitted = value.GetCanBeCommitted;
                Currency = value.Currency;
                Commission = value.Commission;
                Refundable = value.Refundable;
                Refunded = value.Refunded;
                HasSplit = value.HasSplit;
                TransactionId = value.TransactionId;
                Status = value.Status;
                CreateDate = value.CreateDate;
            }
        }
    }
}