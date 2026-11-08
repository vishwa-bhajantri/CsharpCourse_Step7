using System;

namespace SolidPrinciples.WithoutOCP
{
    class PaymentProcessor
    {
        public void ProcessPayment(string paymentType)
        {
            if(paymentType == "CreditCard")
            {
                Console.WriteLine("Processing credit card payment...");
            }
            else if (paymentType == "UPI")
            {
                Console.WriteLine("Processing UPI payment...");
            }
        }
    }
}
