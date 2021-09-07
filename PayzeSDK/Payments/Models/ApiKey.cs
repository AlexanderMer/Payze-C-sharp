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
}