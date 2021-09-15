using PayzeSDK.Payments.Exceptions;
using PayzeSDK.Payments.Requests;
using PayzeSDK.Payments.Responses;

namespace PayzeSDK.Payments.Abstractions
{
    public interface IPayment
    {
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        JustPayResponse JustPay(JustPayRequest justPayRequest );

        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        AddCardPaymentResponse AddCard(AddCardRequest addCardRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        PayWithCardResponse PayWithCard(PayWithCardRequest payWithCardRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        GetTransactionInformationResponse GetTransactionInformation(GetTransactionInformationRequest getTransactionInformationRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        RefundTransactionResponse RefundTransaction(RefundTransactionRequest refundTransactionRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        GetMerchantBalancePaymentResponse GetMerchantBalance(GetMerchantBalanceRequest getMerchantBalanceRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        CommitTransactionPaymentResponse CommitTransaction(CommitTransactionRequest commitTransactionRequest );
    }
}