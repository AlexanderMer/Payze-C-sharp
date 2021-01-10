using System.Reflection;
using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Payments.Requests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class GetTransactionInformationRequest : IPaymentRequest
    {
        public GetTransactionInformationRequest(string transactionId)
        {
            // Required
            TransactionId = transactionId;
        }

        public string Method { get; } = "getTransactionInfo";

        public string TransactionId { get; }
    }
}