using System;


namespace SolidPrinciples.WithoutLSP
{
    abstract class staff
    {
        public abstract void showRole();

        public abstract void performHelpTask();
    }

    class Chef : staff
    {
        public override void showRole()
        {
            Console.WriteLine("I am a chef.");
        }
        public override void performHelpTask()
        {
            Console.WriteLine("Cooking meals...");
        }
    }

    class Cleaner : staff
    {
        public override void showRole()
        {
            Console.WriteLine("I am a cleaner.");
        }
        public override void performHelpTask()
        {
            Console.WriteLine("Cleaning tables...");
        }
    }

    class Customer : staff
    {
        public override void showRole()
        {
            Console.WriteLine("I am a customer.");
        }
        public override void performHelpTask()
        {
            throw new Exception("Customer Cannot Perform Staff Tasks");
        }
    }
   
}
