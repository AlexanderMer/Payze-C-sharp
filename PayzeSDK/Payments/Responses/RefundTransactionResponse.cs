using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Payments.Responses
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class RefundTransactionResponse : PaymentResponse
    {
        public bool Status { get; set; }

        public RefundTransactionResponse Response
        {
            set => Status = value.Status;
        }
    }
}