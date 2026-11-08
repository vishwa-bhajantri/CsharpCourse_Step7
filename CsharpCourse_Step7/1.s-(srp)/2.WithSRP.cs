using System;


namespace SolidPrinciples.WithSRP
{

    class RestaurantService
    {
        //public void HandleRestaurantTask()
        //{
        //    CookMeals();
        //    ManageAccounting();
        //    CleanTables();
        //    TakeOrders();
        //    ServeFood();
        //}

    }

    class chef
    {
        public void CookMeals()
        {
            Console.WriteLine("Cooking meals...");
        }
    }

    class Accountant
    {
        public void ManageAccounting()
        {
            Console.WriteLine("Managing accounting...");
        }
    }

    class Cleaner
    {
        public void CleanTables()
        {
            Console.WriteLine("Cleaning tables...");
        }
    }

    class OrderTaker
    {
        public void TakeOrders()
        {
            Console.WriteLine("Taking orders...");
        }
    }

    class Waiter
    {
        public void ServeFood()
        {
            Console.WriteLine("Serving food...");
        }
    }
  
}
