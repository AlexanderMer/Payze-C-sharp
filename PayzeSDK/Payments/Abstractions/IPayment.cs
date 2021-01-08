using PayzeSDK.Payments.Requests;
using PayzeSDK.Payments.Responses;

namespace PayzeSDK.Payments.Abstractions
{
    public interface IPayment
    {
        public JustPayResponse JustPay(JustPayRequest justPayRequest );

        public AddCardResponse AddCard(AddCardPaymentRequest addCardPaymentRequest );
        
        public PayWithCardResponse PayWithCard(PayWithCardPaymentRequest payWithCardPaymentRequest );
        
        public PayWithCardAndSplitResponse PayWithCardAndSplit(PayWithCardAndSplitPaymentRequest payWithCardAndSplitPaymentRequest );
        
        public GetTransactionInformationResponse GetTransactionInformation(GetTransactionInformationPaymentRequest getTransactionInformationPaymentRequest );
        
        public RefundTransactionResponse RefundTransaction(RefundTransactionPaymentRequest refundTransactionPaymentRequest );
        
        public GetMerchantBalanceResponse GetMerchantBalance(GetMerchantBalancePaymentRequest getMerchantBalancePaymentRequest );
        
        public CommitTransactionResponse CommitTransaction(CommitTransactionPaymentRequest commitTransactionPaymentRequest );
    }
}