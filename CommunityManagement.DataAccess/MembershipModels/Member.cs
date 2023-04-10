using CommunityManagement.DataAccess.MembershipModels.Details;

namespace CommunityManagement.DataAccess.MembershipModels
{
    public class Member
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public DateTime BirthDay { get; set; }

        public virtual List<Child> Children { get; set; }

        //public DateTime CreationDate { get; set; }

        public DateTime DateOfBaptism { get; set; }

        //public DateTime LastUpdated { get; set; }

        public virtual List<Membership> Memberships { get; set; }

        public string Observation { get; set; }

        public string PhoneNumber { get; set; }

        public string PlaceOfBaptism { get; set; }

        public string SpouseName { get; set; }

        //public int UserUpdated { get; set; }
    }
}