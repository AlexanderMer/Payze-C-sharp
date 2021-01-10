using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Payments.Responses
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class GetMerchantBalancePaymentResponse : PaymentResponse
    {
        public decimal AvailableForCashOutUsd { get; set; }
        public decimal AmountProcessedUsd { get; set; }
        public decimal AmountProcessed { get; set; }
        public decimal AvailableForCashOut { get; set; }
        
        public GetMerchantBalancePaymentResponse Response
        {
            set
            {
                AvailableForCashOutUsd = value.AvailableForCashOutUsd;
                AmountProcessedUsd = value.AmountProcessedUsd;
                AmountProcessed = value.AmountProcessed;
                AvailableForCashOut = value.AvailableForCashOut;
            }
        }
    }
}