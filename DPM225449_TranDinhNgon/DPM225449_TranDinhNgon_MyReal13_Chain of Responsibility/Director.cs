using System;

namespace Chain.MyRealWorld
{
    public class Director : Approver
    {
        public override void ProcessRequest(LeaveRequest request)
        {
            if (request.Days <= 14)
            {
                Console.WriteLine($"Director approved leave for Employee #{request.EmployeeId} ({request.Days} days, Reason: {request.Reason})");
            }
            else
            {
                Console.WriteLine($"Leave request for Employee #{request.EmployeeId} ({request.Days} days) requires executive review!");
            }
        }
    }
}