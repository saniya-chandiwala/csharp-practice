namespace LeaveApprovalSystemLib
{
    // approves leaves less than 2 days
    public class TeamLead : IApproveLeave
    {
        public string ApproveLeave(LeaveData data)
        {
            if (data.NoOfDays <= 2)
            {
                return "Leave Approved by Team Lead";
            }
            else
            {
                return "Leave Rejected By Team Lead";
            }
        }
    }
}
