namespace LeaveApprovalSystemLib
{
    // processes leave using the selected approver
    public class ProcessLeave
    {
        // sends the leave request to the approver
        public string Leave(IApproveLeave approver, LeaveData data)
        {
            // calls approvers method
            return approver.ApproveLeave(data);
        }
    }
}
