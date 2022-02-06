using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsiblity_HandsOn
{
    public class LeaveRequest
    {
        public string Employee { get; set; }
        public int LeaveDays { get; set; }

        public LeaveRequest(string employee,int leavedays)
        {
            Employee = employee;
            LeaveDays = leavedays;
        }

    }
}
