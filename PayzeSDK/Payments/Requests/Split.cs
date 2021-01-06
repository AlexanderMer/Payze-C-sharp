namespace PayzeSDK.Requests
{
    public class Split
    {
        public string IBAN { get; set; }

        public decimal SplitAmount { get; set; }

        public int PayIn { get; set; }
    }
}