using System;

namespace Chain.MyRealWorld
{
    public class Manager : Approver
    {
        public override void ProcessRequest(LeaveRequest request)
        {
            if (request.Days <= 7)
            {
                Console.WriteLine($"Manager approved leave for Employee #{request.EmployeeId} ({request.Days} days, Reason: {request.Reason})");
            }
            else if (successor != null)
            {
                successor.ProcessRequest(request);
            }
        }
    }
}