using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
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

        public Payment(ApiKey apiKey)
        {
            _apiKey = apiKey;
        }

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

            if (result.IsSuccessful) return result.Data;
            
            var message = result?.ErrorException?.InnerException?.Message;
            throw new PaymentException(message);

        }

        private T MakePaymentRequest<T>(IPaymentRequest paymentRequest)
        {
            var request = new RestRequest(Method.POST);

            var body = GetBaseRequestJson();
            body.Add("method", paymentRequest.Method);
            body.Add("data", paymentRequest);

            var bodyString = JsonConvert.SerializeObject(body,
                new JsonSerializerSettings() {ContractResolver = new CamelCasePropertyNamesContractResolver()});

            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", bodyString, ParameterType.RequestBody);

            return MakeRequest<T>(request);
        }

        private JsonObject GetBaseRequestJson()
        {
            return new JsonObject {{"apiKey", _apiKey.Key}, {"apiSecret", _apiKey.Secret}};
        }

        public JustPayResponse JustPay(JustPayRequest justPayRequest)
        {
            return MakePaymentRequest<JustPayResponse>(justPayRequest);
        }

        public AddCardPaymentResponse AddCard(AddCardRequest addCardRequest)
        {
            return MakePaymentRequest<AddCardPaymentResponse>(addCardRequest);
        }

        public PayWithCardResponse PayWithCard(PayWithCardRequest payWithCardRequest)
        {
            return MakePaymentRequest<PayWithCardResponse>(payWithCardRequest);
        }

        public GetTransactionInformationResponse GetTransactionInformation(
            GetTransactionInformationRequest getTransactionInformationRequest)
        {
            return MakePaymentRequest<GetTransactionInformationResponse>(getTransactionInformationRequest);
        }

        public RefundTransactionResponse RefundTransaction(RefundTransactionRequest refundTransactionRequest)
        {
            return MakePaymentRequest<RefundTransactionResponse>(refundTransactionRequest);
        }

        public GetMerchantBalancePaymentResponse GetMerchantBalance(GetMerchantBalanceRequest getMerchantBalanceRequest)
        {
            return MakePaymentRequest<GetMerchantBalancePaymentResponse>(getMerchantBalanceRequest);
        }

        public CommitTransactionPaymentResponse CommitTransaction(CommitTransactionRequest commitTransactionRequest)
        {
            return MakePaymentRequest<CommitTransactionPaymentResponse>(commitTransactionRequest);
        }
    }
}