using System;


namespace SolidPrinciples.WithISP
{
    interface ICook
    {
        void Cook();
        //WithIsp
    }
    interface IAccountManager
    {
        void ManageAccounts();
    }
    interface ICleaner
    {
        void CleanTables();
    }
    class Chef : ICook
    {
        public void Cook()
        {
            Console.WriteLine("Cooking meals...");
        }
    }
    class Accountant : IAccountManager
    {
        public void ManageAccounts()
        {
            Console.WriteLine("Managing Accounts...");
        }
    }
    class Cleaner : ICleaner
    {
        public void CleanTables()
        {
            Console.WriteLine("Cleaning tables...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICook chef = new Chef();
            chef.Cook();

            IAccountManager accountant = new Accountant();
            accountant.ManageAccounts();

            ICleaner cleaner = new Cleaner();
            cleaner.CleanTables();
        }
    }
}
