using System;
using PayzeSDK.Payments.Enums;

namespace PayzeSDK.Payments.Responses.Helpers
{
    public class TransactionLog
    {
        public DateTime Date { get; set; }

        public PaymentStatus StatusBefore { get; set; }

        public PaymentStatus Status { get; set; }

        public string ChangeType { get; set; }
    }
}