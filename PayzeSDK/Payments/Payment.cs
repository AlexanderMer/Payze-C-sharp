using PayzeSDK.Payments.Abstractions;
using PayzeSDK.Payments.Responses;
using PayzeSDK.Requests;
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
        
        public Payment(ApiKey apiKey)
        {
            _apiKey = apiKey;
        }
        
        public JustPayResponse JustPay(JustPayRequest justPayRequest)
        {
            var client = new RestClient("https://payze.io/api/v1") {Timeout = -1};
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter($"application/json", $"{{\"method\": \"justPay\"," +
                                                      $"  \"apiKey\": \"{this._apiKey.Key}\"," +
                                                      $" \"apiSecret\": \"{this._apiKey.Secret}\"," +
                                                      $" \"data\": {{\"amount\": \"{justPayRequest.Amount}\"," +
                                                      $"     \"currency\": \"{justPayRequest.Currency}\"," +
                                                      $"     \"callback\": \"{justPayRequest.CallBack}\"," +
                                                      $"  \"callbackError\": \"{justPayRequest.CallBackError}\"," +
                                                      $" " +
                                                      $"    \"preauthorize\": {justPayRequest.Preauthorize.ToString().ToLower()}" +
                                                      $" }}}}",  ParameterType.RequestBody);
            
            var response = client.Execute<JustPayResponse>(request);

            return response.Data;
        }
    }
}