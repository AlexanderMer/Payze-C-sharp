using PayzeSDK.Payments.Responses;
using PayzeSDK.Requests;

namespace PayzeSDK.Payments.Abstractions
{
    public interface IPayment
    {
        public JustPayResponse JustPay(JustPayRequest justPayRequest );

        public JustPayAndSplitResponse JustPayAndSplit(JustPayAndSplitRequest payAndSplitRequest );
        
        public AddCardResponse AddCard(AddCardRequest addCardRequest );
        
        public PayWithCardResponse PayWithCard(PayWithCardRequest payWithCardRequest );
        
        public PayWithCardAndSplitResponse PayWithCardAndSplit(PayWithCardAndSplitRequest payWithCardAndSplitRequest );
        
        public GetTransactionInformationResponse GetTransactionInformation(GetTransactionInformationRequest getTransactionInformationRequest );
        
        public RefundTransactionResponse RefundTransaction(RefundTransactionRequest refundTransactionRequest );
        
        public GetMerchantBalanceResponse GetMerchantBalance(GetMerchantBalanceRequest getMerchantBalanceRequest );
        
        public CommitTransactionResponse CommitTransaction(CommitTransactionRequest commitTransactionRequest );
    }
}