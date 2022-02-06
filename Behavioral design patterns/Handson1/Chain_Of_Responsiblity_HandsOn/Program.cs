using System;

namespace Chain_Of_Responsiblity_HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest leaveRequest = new LeaveRequest("Vishal", 6);
            ILeaveRequestHandler leaveRequestHandler = new Supervisor();
            leaveRequestHandler.HandleRequest(leaveRequest);

            Console.Read();
        }
    }
}
