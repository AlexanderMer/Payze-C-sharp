using System;

namespace PayzeSDK.Payments.Responses.Helpers
{
    public class TransactionLog
    {
        public DateTime Date { get; set; }

        public string StatusBefore { get; set; }

        public string Status { get; set; }

        public string ChangeType { get; set; }
    }
}