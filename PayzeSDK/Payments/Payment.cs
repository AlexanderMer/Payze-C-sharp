using PayzeSDK.Payments.Abstractions;
using PayzeSDK.Payments.Exceptions;
using PayzeSDK.Payments.Requests;
using PayzeSDK.Payments.Responses;
using RestSharp;

namespace PayzeSDK.Payments
{
    public class ApiKey
    {
        public ApiKey(string apiKey, string apiSecret)
        {
            Key = apiKey;
            Secret = apiSecret;
        }
        
        public string Key { get; }

        public string Secret { get; }
    }

    public class Payment : IPayment
    {
        private readonly ApiKey _apiKey;
        private readonly RestClient _restClient = new RestClient("https://payze.io/api/v1") {Timeout = -1};
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="restRequest"></param>
        /// <typeparam name="T">Response data class</typeparam>
        /// <returns></returns>
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        private T MakeRequest<T>(IRestRequest restRequest)
        {
            var result = _restClient.Execute<T>(restRequest);

            if (!result.IsSuccessful)
            {
                throw new PaymentException(result.ErrorMessage);
            }
            
            return result.Data;
        }

        private T MakePaymentRequest<T>(IPaymentRequest paymentRequest)
        {
            var request = new RestRequest(Method.POST);
            
            var body = GetBaseRequetJson(paymentRequest); 
            body.Add("method", paymentRequest.Method);
            body.Add("data", paymentRequest);
            
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            return MakeRequest<T>(request);
        }

        private JsonObject GetBaseRequetJson(IPaymentRequest paymentRequest)
        {
            return new JsonObject {{"apiKey", _apiKey.Key}, {"apiSecret", _apiKey.Secret}};
        }
        
        public Payment(ApiKey apiKey)
        {
            _apiKey = apiKey;
        }
        
        public JustPayResponse JustPay(JustPayRequest justPayRequest)
        {
            return MakePaymentRequest<JustPayResponse>(justPayRequest);
        }

        public AddCardResponse AddCard(AddCardPaymentRequest addCardPaymentRequest)
        {
            return MakePaymentRequest<AddCardResponse>(addCardPaymentRequest);
        }

        public PayWithCardResponse PayWithCard(PayWithCardPaymentRequest payWithCardPaymentRequest)
        {
            return MakePaymentRequest<PayWithCardResponse>(payWithCardPaymentRequest);
        }

        public PayWithCardAndSplitResponse PayWithCardAndSplit(PayWithCardAndSplitPaymentRequest payWithCardAndSplitPaymentRequest)
        {
            return MakePaymentRequest<PayWithCardAndSplitResponse>(payWithCardAndSplitPaymentRequest);
        }

        public GetTransactionInformationResponse GetTransactionInformation(
            GetTransactionInformationPaymentRequest getTransactionInformationPaymentRequest)
        {
            return MakePaymentRequest<GetTransactionInformationResponse>(getTransactionInformationPaymentRequest);
        }

        public RefundTransactionResponse RefundTransaction(RefundTransactionPaymentRequest refundTransactionPaymentRequest)
        {
            return MakePaymentRequest<RefundTransactionResponse>(refundTransactionPaymentRequest);
        }

        public GetMerchantBalanceResponse GetMerchantBalance(GetMerchantBalancePaymentRequest getMerchantBalancePaymentRequest)
        {
            return MakePaymentRequest<GetMerchantBalanceResponse>(getMerchantBalancePaymentRequest);
        }

        public CommitTransactionResponse CommitTransaction(CommitTransactionPaymentRequest commitTransactionPaymentRequest)
        {
            return MakePaymentRequest<CommitTransactionResponse>(commitTransactionPaymentRequest);
        }
    }
}