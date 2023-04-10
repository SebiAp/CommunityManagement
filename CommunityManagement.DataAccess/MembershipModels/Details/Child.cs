namespace CommunityManagement.DataAccess.MembershipModels.Details
{
    public class Child
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string BirthPlace { get; set; }

        //public DateTime CreationDate { get; set; }

        public int MemberId { get; set; }

        public string Mentions { get; set; }
        public virtual Member Member { get; set; }

        //public int UserCreated { get; set; }
    }
}