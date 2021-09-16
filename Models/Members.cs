namespace LendingLibrary.Models
{
    public class Member
    {
        public string MemberName { get; set; }
        public int MemberId { get; set; }
        public Member(string memberName, int memberId)
        {
            MemberName = memberName;
            MemberId = memberId;
        }
    }
}