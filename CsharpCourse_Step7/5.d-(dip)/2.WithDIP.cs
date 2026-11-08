using System;


namespace SolidPrinciples.WithDIP
{
    interface IFoodPreparationService
    {
        void PrepareOrder(string order);
    }

    class KitchenService : IFoodPreparationService
    {
        public void PrepareOrder(string order)
        {
            Console.WriteLine($"Preparing Order for the Main Kitchen {order}");
        }
    }

    class ExternalKitchenService : IFoodPreparationService
    {
        public void PrepareOrder(string order)
        {
            Console.WriteLine($"Preparing Order for the External Kitchen {order}");
        }
    }

    class OrderHandler
    {
        IFoodPreparationService kithchenService;

        public OrderHandler(IFoodPreparationService foodPreparationService)
        {
            kithchenService = foodPreparationService;
        }

        public void TakeOrder(string order)
        {
            Console.WriteLine($"Server Taking The Order {order}");
            kithchenService.PrepareOrder(order);
        }
    }

    class Program
    {
        static void Main()
        {
            KitchenService service1 = new KitchenService();
            OrderHandler orderHandler = new OrderHandler(service1);
            orderHandler.TakeOrder("Pizza");

            Console.WriteLine("Order Has Delivered");

            ExternalKitchenService service2 = new ExternalKitchenService();
            OrderHandler orderHandler1 = new OrderHandler(service2);
            orderHandler1.TakeOrder("Burger");

            Console.WriteLine("Order Has Delivered");
        }
    }
}
