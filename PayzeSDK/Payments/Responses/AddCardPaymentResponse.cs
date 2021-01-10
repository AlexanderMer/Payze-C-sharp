using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Payments.Responses
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class AddCardPaymentResponse : PaymentResponse
    {
        public string CardId { get; set; }

        public string TransactionUrl { get; set; }

        public string TransactionId { get; set; }

        public AddCardPaymentResponse Response
        {
            set
            {
                CardId = value.CardId;
                TransactionUrl = value.TransactionUrl;
                TransactionId = value.TransactionId;
            }
        }
    }
}