using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_HandsOn8
{
    public class MessageSubscriberOne : Observer

    {



        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberOne :: " + m.getMessageContent());

        }

    }


    public class MessageSubscriberTwo : Observer

    {



        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberTwo :: " + m.getMessageContent());

        }

    }


    public class MessageSubscriberThree : Observer

    {



        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberThree :: " + m.getMessageContent());

        }

    }
}
