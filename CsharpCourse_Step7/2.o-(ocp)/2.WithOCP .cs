using System;

namespace SolidPrinciples.WithOCP
{
    interface IPaymentProcessor
    {
        void ProcessPayment();
    }

    class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }

    class UpiPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing UPI payment...");
        }
    }

    class PaypalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment...");
        }
    }

    class debitCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing debit card payment...");
        }
    }

    class PaymentProcessor
    {

        public void ProcessPayment(IPaymentProcessor paymentProcessor)
        {
            paymentProcessor.ProcessPayment();
        }
        static void Main(string[] args)
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();

            IPaymentProcessor creditCardPayment = new CreditCardPaymentProcessor();
            IPaymentProcessor upiPayment = new UpiPaymentProcessor();
            IPaymentProcessor paypalPayment = new PaypalPaymentProcessor();
            IPaymentProcessor debitCardPayment = new debitCardPaymentProcessor();

            paymentProcessor.ProcessPayment(creditCardPayment);
            paymentProcessor.ProcessPayment(upiPayment);
            paymentProcessor.ProcessPayment(paypalPayment);
            paymentProcessor.ProcessPayment(debitCardPayment);
        }
    }
}
