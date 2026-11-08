using SolidPrinciples.WithoutLSP;
using System;


namespace SolidPrinciples.WithLSP
{
    abstract class Person
    {
        public virtual void showRole()
        {
            Console.WriteLine("This is a Person");
        }

    }

    class Staff : Person
    {
        public override void showRole()
        {
            Console.WriteLine("This is a Staff Member.");
        }
        public virtual void performHelpTask()
        {
            Console.WriteLine("Performing a Staff Task...");
        }
    }
    
    class Chef : Staff
    {
        public override void performHelpTask()
        {
            Console.WriteLine("Performing a Chef Task...");
        }

        public override void showRole()
        {
            Console.WriteLine("This is a Staff Member Chef.");
        }

    }

    class Cleaner : Staff
    {
        public override void performHelpTask()
        {
            Console.WriteLine("Performing a Cleaner Task...");
        }
        public override void showRole()
        {
            Console.WriteLine("This is a Staff Member Cleaner.");
        }
    }

    class Customer : Person
    {
        public override void showRole()
        {
            Console.WriteLine("This is a Customer.");
        }

        public void placeOrder()
        {
            Console.WriteLine("Placing an order...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Staff chef = new Chef();
            Staff cleaner = new Cleaner();

            chef.showRole();
            chef.performHelpTask();

            cleaner.showRole();
            cleaner.performHelpTask();

            Person customer = new Customer();
            customer.showRole();
            //customer.placeOrder(); // This line will cause a compile-time error because 'placeOrder' is not defined in the 'Person' class.

            Customer cus1 = new Customer();
            cus1.placeOrder(); // This line will work because 'placeOrder' is defined in the 'Customer' class.
        }
    }
}
