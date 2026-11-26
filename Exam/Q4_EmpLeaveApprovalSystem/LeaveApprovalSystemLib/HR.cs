namespace LeaveApprovalSystemLib
{
    // approves leaves less than 5 days
    public class HR : IApproveLeave
    {
        public string ApproveLeave(LeaveData data)
        {
            if (data.NoOfDays <= 5)
            {
                return "Leave Approved by HR Manager";
            }
            else
            {
                return "Leave Rejected By HR Manager";
            }
        }
    }
}
