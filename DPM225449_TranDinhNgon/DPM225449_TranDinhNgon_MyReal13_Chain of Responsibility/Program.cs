using System;
using System.IO;

namespace Chain.MyRealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Approver supervisor = new Supervisor();
            Approver manager = new Manager();
            Approver director = new Director();

            supervisor.SetSuccessor(manager);
            manager.SetSuccessor(director);

            var requests = new[]
            {
                new LeaveRequest(1001, 2, "Personal"),
                new LeaveRequest(1002, 5, "Medical"),
                new LeaveRequest(1003, 10, "Vacation"),
                new LeaveRequest(1004, 20, "Family Emergency")
            };

            foreach (var request in requests)
            {
                supervisor.ProcessRequest(request);
            }

            Console.ReadKey();
        }
    }
}