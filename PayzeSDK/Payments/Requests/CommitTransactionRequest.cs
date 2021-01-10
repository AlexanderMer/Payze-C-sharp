using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Payments.Requests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class CommitTransactionRequest : IPaymentRequest
    {
        public CommitTransactionRequest(string transactionId, decimal amount = 0)
        {
            // Required
            TransactionId = transactionId;
            
            // Optional
            Amount = amount;
        }
        
        public string Method { get; } = "commit";

        public string TransactionId { get; }

        public decimal Amount { get; set; }
    }
}