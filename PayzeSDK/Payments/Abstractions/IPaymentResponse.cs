namespace PayzeSDK.Payments.Abstractions
{
    public interface IPaymentResponse
    {
        // In case of error, the message will be stored here
        string Error { set; }
    }
}