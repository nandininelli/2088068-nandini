using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chatMediator = new ChatMediator();
            IUser u1 = new BasicUser();
            u1.Name = "Pratik";
            IUser u2 = new PremiumUser();
            u2.Name = "Ajay";
            IUser u3 = new BasicUser();
            u3.Name = "Nikhil";
            chatMediator.AddUser(u1);
            chatMediator.AddUser(u2);
            chatMediator.AddUser(u3);



            chatMediator.SendMessage(u1,"Hello Everyone");

            Console.ReadLine();
        }
    }
}
