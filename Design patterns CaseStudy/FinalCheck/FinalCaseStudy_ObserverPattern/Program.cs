using System;

namespace FinalCaseStudy_ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IObserver Observer1 = new Observer("Holi", 10);
            IObserver Observer2 = new Observer("Diwali", 30);
            IObserver Observer3 = new Observer("Vughadhi", 200);

            NotificationService notificationService = new NotificationService();

            notificationService.AddSubscriber(Observer1);
            notificationService.AddSubscriber(Observer2);
            notificationService.AddSubscriber(Observer3);
            
            notificationService.RemoveSubscriber(Observer3);

            Console.ReadKey();
        }
    }
}
