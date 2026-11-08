using System;


namespace SolidPrinciples.WithoutDIP
{
    class KitchenService
    {
        public void prepareOrder(string order)
        {
            Console.WriteLine($"Preparing {order} in the Main Kitchen...");
        }
    }

    class ExternalKitchenService
    {
        public void prepareOrder(string order)
        {
            Console.WriteLine($"Preparing {order} in the External Kitchen...");
        }
    }

    class OrderHandler
    {
        private KitchenService kitchenService = new KitchenService();

        public void TakeOrder (string order)
        {
            Console.WriteLine($"Server Taking Main Kitchen order {order}");
            kitchenService.prepareOrder(order);
        }

        public void TakeExternalOrder(string order)
        {
            Console.WriteLine($"Server Taking External Kitchen order {order}");
            kitchenService.prepareOrder(order);
        }
    }

}
