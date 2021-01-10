using System;

namespace PayzeSDK.Payments.Exceptions
{
    [Serializable]
    public class PaymentException : Exception
    {
        public PaymentException(string message) : base(message)
        {
        }
    }
}