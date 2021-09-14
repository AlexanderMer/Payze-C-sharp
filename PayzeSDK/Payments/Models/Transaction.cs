using System;
using System.Collections.Generic;
using PayzeSDK.Payments.Enums;
using PayzeSDK.Payments.Responses.Helpers;

namespace PayzeSDK.Payments
{
    public class Transaction
    {
        public string CardMask { get; set; }

        public decimal Amount { get; set; }

        public List<TransactionLog> Log { get; set; }

        public bool GetCanBeCommitted { get; set; }

        public string ResultCode { get; set; }

        public string TransactionId { get; set; }

        public DateTime CommitDate { get; set; }

        public decimal FinalAmount { get; set; }

        public Currency Currency { get; set; }

        public decimal Commission { get; set; }

        public bool Refundable { get; set; }

        public decimal Refunded { get; set; }

        public bool HasSplit { get; set; }

        public PaymentStatus Status { get; set; }

        public DateTime CreateDate { get; set; }
    }
}