using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeCaseStudy_ObserverPattern
{
    class NotificationService:INotificationService
    {
        List<INotificationObserver> notificationObserverList = new List<INotificationObserver>();

        int count = 1;

        public void AddSubscriber(INotificationObserver notificationObserver)
        {
            notificationObserverList.Add(notificationObserver);
            Console.WriteLine(count + " List of Subscribers");
            count++;
            foreach (var list in notificationObserverList)
            {
                Console.WriteLine(list.Name);
            }
            NotifySubscriber();
        }

        public void NotifySubscriber()
        {
            foreach (var list in notificationObserverList)
            {
                list.OnServerDown();
            }
        }

        public void RemoveSubscriber(INotificationObserver notificationObserver)
        {
            notificationObserverList.Remove(notificationObserver);
            Console.WriteLine("List of Subscribers are as follows");
            foreach (var list in notificationObserverList)
            {
                Console.WriteLine(list.Name);
            }
        }
    }
}
