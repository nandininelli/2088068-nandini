using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeCaseStudy_ObserverPattern
{
    interface INotificationObserver
    {
        string Name { get; set; }
        void OnServerDown();
    }
}
