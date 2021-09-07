using PayzeSDK.Payments.Exceptions;
using PayzeSDK.Payments.Requests;
using PayzeSDK.Payments.Responses;
using System.Threading.Tasks;

namespace PayzeSDK
{
    public interface IPayzeClient
    {
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        Task<JustPayResponse> JustPay(JustPayRequest justPayRequest );

        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        Task<AddCardPaymentResponse> AddCard(AddCardRequest addCardRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        Task<PayWithCardResponse> PayWithCard(PayWithCardRequest payWithCardRequest );

        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        Task<GetTransactionInformationResponse> GetTransactionInformation(GetTransactionInformationRequest getTransactionInformationRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        Task<RefundTransactionResponse> RefundTransaction(RefundTransactionRequest refundTransactionRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        Task<GetMerchantBalancePaymentResponse> GetMerchantBalance(GetMerchantBalanceRequest getMerchantBalanceRequest );
        
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        Task<CommitTransactionPaymentResponse> CommitTransaction(CommitTransactionRequest commitTransactionRequest );
    }
}