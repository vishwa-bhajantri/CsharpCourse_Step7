using System;


namespace SolidPrinciples.WithoutSRP
{

    class RestaurantService
    {
        public void HandleRestaurantTask()
        {
            CookMeals();
            ManageAccounting();
            CleanTables();
            TakeOrders();
            ServeFood();
        }

        public void CookMeals()
        {
            Console.WriteLine("Cooking meals...");
        }

        public void ManageAccounting()
        {
            Console.WriteLine("Managing accounting...");
        }

        public void CleanTables()
        {
            Console.WriteLine("Cleaning tables...");
        }

        public void TakeOrders()
        {
            Console.WriteLine("Taking orders...");
        }

        public void ServeFood()
        {
            Console.WriteLine("Serving food...");
        }
    }
    class Program
    {
        public static void Main()
        {
            RestaurantService restaurantService = new RestaurantService();
            restaurantService.HandleRestaurantTask();
        }
    }
}
