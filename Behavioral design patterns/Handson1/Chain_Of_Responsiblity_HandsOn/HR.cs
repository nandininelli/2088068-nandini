using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsiblity_HandsOn
{
    public class HR : ILeaveRequestHandler
    {
        private ILeaveRequestHandler NextHandler;
        public ILeaveRequestHandler nextHandler { get { return NextHandler; } set { NextHandler =value; } }

        public void HandleRequest(LeaveRequest leave)
        {   
            Console.WriteLine("Approved By HR");
        }
    }
}
