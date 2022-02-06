using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeCaseStudy_ObserverPattern
{
    class SteveObserver:INotificationObserver
    {
        public string Name { get; set; }

        public void OnServerDown()
        {
            Console.WriteLine(" Steve recived notification from " + Name);
        }
    }
}
