namespace FactoryMethodDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            //MoneyBackFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }

            ILogger logger;
            logger = LoggerFactory.CreateLogger("console");
            logger.Log("This is a console log!");
            logger = LoggerFactory.CreateLogger("file");
            logger.Log("This message is written to a file.");


            INotificationSender notificationSender;
            notificationSender = NotificationFactory.CreateNotificationSender("email");
            notificationSender.SendNotification("This is an email notification!");
            notificationSender = NotificationFactory.CreateNotificationSender("sms");
            notificationSender.SendNotification("This is an SMS notification!");
            notificationSender = NotificationFactory.CreateNotificationSender("push");
            notificationSender.SendNotification("This is a push notification!");


            Console.WriteLine("Select the payment gateway (PayPal, Stripe, CreditCard): ");
            string gatewayName = Console.ReadLine();
            try
            {
                IPaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
                paymentGateway.ProcessPayment(100.00M);  // Example amount
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadLine();
        }
    }
}
