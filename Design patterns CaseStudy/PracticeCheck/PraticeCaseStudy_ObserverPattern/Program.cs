using System;

namespace PraticeCaseStudy_ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationObserver steveObserver =new SteveObserver();
            steveObserver.Name = "John";
            INotificationObserver johnObserver = new JohnObserver();
            johnObserver.Name = "Ali";
            NotificationService notificationService = new NotificationService();
            notificationService.AddSubscriber(steveObserver);
            notificationService.AddSubscriber(johnObserver);
          //  notificationService.NotifySubscriber();
            notificationService.RemoveSubscriber(steveObserver);

            Console.ReadKey();

        }
    }
}
