namespace LeaveApprovalSystemLib
{
    // interface implemented by team lead, hr manager and dept head
    public interface IApproveLeave
    {
        string ApproveLeave(LeaveData data);
    }
}
