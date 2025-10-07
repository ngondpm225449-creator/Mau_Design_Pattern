using System;

namespace Chain.MyRealWorld
{
    public class Supervisor : Approver
    {
        public override void ProcessRequest(LeaveRequest request)
        {
            if (request.Days <= 3)
            {
                Console.WriteLine($"Supervisor approved leave for Employee #{request.EmployeeId} ({request.Days} days, Reason: {request.Reason})");
            }
            else if (successor != null)
            {
                successor.ProcessRequest(request);
            }
        }
    }
}