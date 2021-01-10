using PayzeSDK.Payments.Exceptions;

namespace PayzeSDK.Payments.Abstractions
{
    public abstract class PaymentResponse : IPaymentResponse
    {
        public string Error {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    throw new PaymentException(value);
                }
            }
        }
    }
}