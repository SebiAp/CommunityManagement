namespace CommunityManagement.DataAccess.MembershipModels
{
    public class DisciplineAction
    {
        public int Id { get; set; }

        //public DateTime CreationDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual Membership Membership { get; set; }

        public int MembershipId { get; set; }

        public string Observation { get; set; }

        public string Reason { get; set; }

        public DateTime StartDate { get; set; }

        //public int UserCreated { get; set; }
    }
}