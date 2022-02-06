using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeCaseStudy_ObserverPattern
{
    class JohnObserver:INotificationObserver
    {
        public string Name { get; set; }

        public void OnServerDown()
        {
            Console.WriteLine(" John recived notification from " + Name);
        }
    }
}
