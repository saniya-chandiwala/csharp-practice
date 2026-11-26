namespace LeaveApprovalSystemLib
{
    // approves leaves less than 10 days
    public class DeptHead : IApproveLeave
    {
        public string ApproveLeave(LeaveData data)
        {
            if (data.NoOfDays <= 10)
            {
                return "Leave Approved by Department Head";
            }
            else
            {
                return "Leave Rejected by Department Head";
            }
        }
    }
}
