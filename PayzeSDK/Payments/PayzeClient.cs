using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PayzeSDK.Payments;
using PayzeSDK.Payments.Abstractions;
using PayzeSDK.Payments.Exceptions;
using PayzeSDK.Payments.Requests;
using PayzeSDK.Payments.Responses;
using RestSharp;
using System.Threading.Tasks;

namespace PayzeSDK
{
    public class PayzeClient : IPayzeClient
    {
        private readonly ApiKey _apiKey;
        private readonly RestClient _restClient;

        public PayzeClient(ApiKey apiKey)
        {
            _apiKey = apiKey;
            _restClient = new RestClient("https://payze.io/api/v1") { Timeout = -1 };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="restRequest"></param>
        /// <typeparam name="T">Response data class</typeparam>
        /// <returns></returns>
        /// <exception cref="PaymentException">Throws in case of unsuccessful request</exception>
        private async Task<T> MakeRequest<T>(IRestRequest restRequest)
        {
            var result = await _restClient.ExecuteAsync<T>(restRequest);

            if (result.IsSuccessful) return result.Data;
            
            var message = result?.ErrorException?.InnerException?.Message;
            throw new PaymentException(message);
        }

        private async Task<T> MakePaymentRequest<T>(IPaymentRequest paymentRequest)
        {
            var request = new RestRequest(Method.POST);

            var body = new JsonObject { { "apiKey", _apiKey.Key }, { "apiSecret", _apiKey.Secret } };
            body.Add("method", paymentRequest.Method);
            body.Add("data", paymentRequest);

            var bodyString = JsonConvert.SerializeObject(body,
                new JsonSerializerSettings() {ContractResolver = new CamelCasePropertyNamesContractResolver()});

            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", bodyString, ParameterType.RequestBody);

            return await MakeRequest<T>(request);
        }

        public async Task<JustPayResponse> JustPay(JustPayRequest justPayRequest) => 
            await MakePaymentRequest<JustPayResponse>(justPayRequest);
        
        public async Task<AddCardPaymentResponse> AddCard(AddCardRequest addCardRequest) =>
            await MakePaymentRequest<AddCardPaymentResponse>(addCardRequest);
        
        public async Task<PayWithCardResponse> PayWithCard(PayWithCardRequest payWithCardRequest) =>
            await MakePaymentRequest<PayWithCardResponse>(payWithCardRequest);

        public async Task<GetTransactionInformationResponse> GetTransactionInformation(
            GetTransactionInformationRequest getTransactionInformationRequest) => 
            await MakePaymentRequest<GetTransactionInformationResponse>(getTransactionInformationRequest);

        public async Task<RefundTransactionResponse> RefundTransaction(RefundTransactionRequest refundTransactionRequest) => 
            await MakePaymentRequest<RefundTransactionResponse>(refundTransactionRequest);

        public async Task<GetMerchantBalancePaymentResponse> GetMerchantBalance(GetMerchantBalanceRequest getMerchantBalanceRequest) => 
            await MakePaymentRequest<GetMerchantBalancePaymentResponse>(getMerchantBalanceRequest);

        public async Task<CommitTransactionPaymentResponse> CommitTransaction(CommitTransactionRequest commitTransactionRequest) =>
            await MakePaymentRequest<CommitTransactionPaymentResponse>(commitTransactionRequest);
    }
}