using System;


namespace SolidPrinciples.WithoutISP
{
    interface IRestaurantService
    {
        void Cook();
        void ManageAccounts();
        void CleanTabless();
        }

        class Chef : IRestaurantService
        {
            public void Cook()
            {
                Console.WriteLine("Cooking meals...");
            }
            public void ManageAccounts()
            {
                throw new Exception("Chef Cannot Manage Accounts");
            }
            public void CleanTabless()
            {
                throw new Exception("Chef Cannot Clean Tables");
            }
        }
}
