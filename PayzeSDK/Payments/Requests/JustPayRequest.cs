namespace PayzeSDK.Requests
{
    public class JustPayRequest
    {
        public string Method { get; } = "justPay";
        
        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public string CallBack { get; set; }

        public string CallBackError { get; set; }

        public bool Preauthorize { get; set; }
    }
}