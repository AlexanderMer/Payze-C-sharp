using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Payments.Responses
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class RefundTransactionResponse : PaymentResponse
    {
        public bool Success { get; set; }

        public Transaction Transaction { get; set; }

        public RefundTransactionResponse Response
        {
            set
            {
                Success = value.Success;
                Transaction = value.Transaction;
            }
            
        }
    }
}