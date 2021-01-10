using PayzeSDK.Payments.Exceptions;
using PayzeSDK.Payments.Requests;
using PayzeSDK.Payments.Responses;

namespace PayzeSDK.Payments.Abstractions
{
    public interface IPayment
    {
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        public JustPayResponse JustPay(JustPay justPay );

        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        public AddCardPaymentResponse AddCard(AddCardRequest addCardRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        public PayWithCardResponse PayWithCard(PayWithCard payWithCard );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        public GetTransactionInformationResponse GetTransactionInformation(GetTransactionInformationRequest getTransactionInformationRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        public RefundTransactionResponse RefundTransaction(RefundTransactionRequest refundTransactionRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        public GetMerchantBalancePaymentResponse GetMerchantBalance(GetMerchantBalanceRequest getMerchantBalanceRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        public CommitTransactionPaymentResponse CommitTransaction(CommitTransactionRequest commitTransactionRequest );
    }
}