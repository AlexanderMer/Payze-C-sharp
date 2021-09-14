using System;

namespace PayzeSDK.Payments
{
    public class CashOutOrder
    {
        public DateTime Date { get; set; }

        public string Bank { get; set; }

        public decimal CashOutPrice { get; set; }

        public string Status { get; set; }
    }
}