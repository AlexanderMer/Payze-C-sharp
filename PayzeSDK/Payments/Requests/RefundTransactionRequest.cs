using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Payments.Requests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class RefundTransactionRequest : IPaymentRequest
    {
        public RefundTransactionRequest(string transactionId, decimal amount = 0)
        {
            // Required
            TransactionId = transactionId;
            
            // Optional
            Amount = amount;
        }
        
        public string Method { get; } = "refund";

        public string TransactionId { get; set; }

        public decimal Amount { get; set; }
    }
}