using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class BasicUser:IUser
    {
        ChatMediator chatMediator = new ChatMediator();
        
        public string Name { get; set; }

        public void ReceiveMessage(IUser user, string message)
        {
            Console.WriteLine(message+" received by "+this.Name);
        }

        public void SendMessage(string message)
        {
            chatMediator.SendMessage(this,message);
        }
    }
}
