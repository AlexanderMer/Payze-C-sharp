using System;

namespace PayzeSDK.Payments.Exceptions
{
    public class PaymentException : Exception
    {
        public PaymentException(string message)
        {
            Message = message;
        }
        
        public override string Message { get; }
    }
}