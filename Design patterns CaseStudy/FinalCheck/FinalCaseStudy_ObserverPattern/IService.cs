using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudy_ObserverPattern
{
    interface IService
    {
        void AddSubscriber(IObserver notificationObserver);
        void RemoveSubscriber(IObserver notificationObserver);
        void NotifySubscriber();
    }
}
