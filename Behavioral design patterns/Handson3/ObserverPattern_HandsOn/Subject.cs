using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_HandsOn8
{
    public interface Subject

    {
       int GetState { get; set; }

        void ChangeState(int val);
        void Attach(Observer o);

        void Detach(Observer o);
    }
}
