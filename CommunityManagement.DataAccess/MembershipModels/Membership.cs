using CommunityManagement.DataAccess.MembershipModels.Enums;

namespace CommunityManagement.DataAccess.MembershipModels
{
    public class Membership
    {
        public int Id { get; set; }

        //public DateTime CreationDate { get; set; }

        public virtual List<DisciplineAction> DisciplineActions { get; set; }

        public DateTime? EndMembership { get; set; }

        public virtual Member Member { get; set; }

        public int MemberId { get; set; }

        public virtual MembershipRequest MembershipRequest { get; set; }

        public MembershipStatus MembershipStatus { get; set; }

        public string Mentions { get; set; }

        public int RequestId { get; set; }

        public DateTime StartMembership { get; set; }

        //public int UserCreated { get; set; }
    }
}