# Payze C# SDK
## Installation
Payze SDK can be installed via nuget package manager
Go to nuget and search for "PayzeSDK"
![nuget screenshot](https://github.com/AlexanderMer/PayzeSDK_C-Sharp/blob/master/PayzeSDK/nuget.png?raw=true)

## Usage
PayzeSDK is similar in usage as Payze API.  
All you have to do is instantiate the main **Payment** class supplying your **API Key** and **API Secret**  
which can be found [here](https://payze.io/api-keys)

The Payments class all Payze operations like _justPay_, _addCard_, _payWithCard_ etc...  
All requests and responses are wrapped in their respective classes.  
For Example: justPay takes _JustPayRequest_ object and returns _JustPayResponse_
## Example Program
```
  internal static class Program
    {
        /*
              JustPayResponse result = PaymentGate.JustPay(new JustPayRequest
                (
                    (decimal) 1.0,
                    Currency.GEL,
                    false
                ));
        */
        
        // EXAMPLE CALLS:
        // Below you can check a test program which calls every api method


        // Instantiating the main Payment class
        private static readonly Payment PaymentGate = new Payment(new ApiKey("<Your api key>", "<Your api secret>"));

        // variables to store info between responses
        private static readonly string _iban = "<Your iban>";
        private static string _cardToken = "";
        private static string _transactionId = "";


        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Payze!");

            JustPay();
            JustPayWithSplit();
            AddCard();
            PayWithCard();
            PayWithCardAndSplit();
            GetTransactionInformation();
            RefundTransaction();
        }

        private static void JustPay()
        {
            Console.WriteLine("========= Just Pay  ======");

            try
            {
                var result = PaymentGate.JustPay(new JustPayRequest
                (
                    (decimal) 1.0,
                    Currency.GEL,
                    false
                ));

                Console.WriteLine(result.TransactionId);
                Console.WriteLine(result.TransactionUrl);
            }
            catch (PaymentException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }

        private static void JustPayWithSplit()
        {
            Console.WriteLine("========= Just Pay with Splits ======");

            try
            {
                var result = PaymentGate.JustPay(new JustPayRequest
                    (
                        (decimal) 2.0,
                        Currency.GEL,
                        false
                    )
                    {Splits = new List<Split>() {new() {IBAN = _iban, SplitAmount = 1, PayIn = 0}}});

                Console.WriteLine(result.TransactionId);
                Console.WriteLine(result.TransactionUrl);
            }
            catch (PaymentException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }

        private static void AddCard()
        {
            Console.WriteLine("========= Add Card  ======");

            try
            {
                var result = PaymentGate.AddCard(new AddCardRequest());

                _cardToken = result.CardId;
                Console.WriteLine(result.CardId);
                Console.WriteLine(result.TransactionId);
                Console.WriteLine(result.TransactionUrl);
            }
            catch (PaymentException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }

        private static void PayWithCard()
        {
            Console.WriteLine("========= Pay with Card  ======");

            try
            {
                var result = PaymentGate.PayWithCard(new PayWithCardRequest(
                    1, Currency.GEL, false, _cardToken));

                _transactionId = result.TransactionId;

                Console.WriteLine(result.TransactionId);
                Console.WriteLine(result.TransactionInfo.Status);
            }
            catch (PaymentException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }

        private static void PayWithCardAndSplit()
        {
            Console.WriteLine("========= Pay with Card and Split  ======");

            try
            {
                var result = PaymentGate.PayWithCard(new PayWithCardRequest(
                    (decimal) 2.0, Currency.GEL, false, _cardToken)
                {
                    Splits = new List<Split>() {new Split() {IBAN = _iban, SplitAmount = 1}}
                });

                _transactionId = result.TransactionId;

                Console.WriteLine(result.TransactionId);
                Console.WriteLine(result.TransactionInfo);
            }
            catch (PaymentException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }

        private static void GetTransactionInformation()
        {
            Console.WriteLine("========= Get Transaction Information  ======");

            try
            {
                var result = PaymentGate.GetTransactionInformation(new GetTransactionInformationRequest(
                    _transactionId
                ));

                Console.WriteLine(result.TransactionId);
                Console.WriteLine(result.Amount);
                Console.WriteLine(result.Commission);
                Console.WriteLine(result.Currency);
                Console.WriteLine(result.Refundable);
                Console.WriteLine(result.Refunded);
                Console.WriteLine(result.Log);
                Console.WriteLine(result.Status);
                Console.WriteLine(result.CreateDate);
                Console.WriteLine(result.FinalAmount);
                Console.WriteLine(result.HasSplit);
                Console.WriteLine(result.GetCanBeCommitted);
                Console.WriteLine(result.CreateDate);
            }
            catch (PaymentException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }

        private static void RefundTransaction()
        {
            Console.WriteLine("========= Refund Transaction  ======");

            try
            {
                var result = PaymentGate.RefundTransaction(new RefundTransactionRequest(_transactionId));

                Console.WriteLine(result.Success);
                Console.WriteLine(result.Transaction.Amount);
            }
            catch (PaymentException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
```