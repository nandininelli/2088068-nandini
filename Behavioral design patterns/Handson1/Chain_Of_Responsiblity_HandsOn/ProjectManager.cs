using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsiblity_HandsOn
{
    public class ProjectManager : ILeaveRequestHandler
    {
        private ILeaveRequestHandler NextHandler;
        public ILeaveRequestHandler nextHandler { get { return NextHandler; }
            set {  NextHandler =value; }
        }

        public void HandleRequest(LeaveRequest leave)
        {
            if(leave.LeaveDays<6&&leave.LeaveDays>2)
            {
                Console.WriteLine("Approved By Project Manager");
            }
            else
            {
                Console.WriteLine("Passed to HR due to number of leaves");
                nextHandler = new HR();
                nextHandler.HandleRequest(leave);
            }
        }
    }
}
