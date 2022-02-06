using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsiblity_HandsOn
{
    public interface ILeaveRequestHandler
    {
         ILeaveRequestHandler nextHandler { get; set; }

        void HandleRequest(LeaveRequest leave);
    }
}
