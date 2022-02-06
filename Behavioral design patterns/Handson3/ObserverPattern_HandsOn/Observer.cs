using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_HandsOn8
{
    public interface Observer
    {
        void Update(Message m);
    }
}
