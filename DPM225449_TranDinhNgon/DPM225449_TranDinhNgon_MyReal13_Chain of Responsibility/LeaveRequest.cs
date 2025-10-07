namespace Chain.MyRealWorld
{
    public class LeaveRequest
    {
        public int EmployeeId { get; set; }
        public int Days { get; set; }
        public string Reason { get; set; }

        public LeaveRequest(int employeeId, int days, string reason)
        {
            EmployeeId = employeeId;
            Days = days;
            Reason = reason;
        }
    }
}