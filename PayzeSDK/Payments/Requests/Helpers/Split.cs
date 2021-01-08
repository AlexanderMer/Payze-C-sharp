namespace PayzeSDK.Payments.Requests.Helpers
{
    public class Split
    {
        public string IBAN { get; set; }

        public decimal SplitAmount { get; set; }

        public int PayIn { get; set; } = 0;

        public override string ToString()
        {
            return $"{{ \"iban\" : \"{IBAN}\", \"amount\": {SplitAmount}, \"payIn\": {PayIn} }}";
        }
    }
}