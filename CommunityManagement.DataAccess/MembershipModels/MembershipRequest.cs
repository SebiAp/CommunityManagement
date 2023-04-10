using CommunityManagement.DataAccess.MembershipModels.Enums;

namespace CommunityManagement.DataAccess.MembershipModels
{
    public class MembershipRequest
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsMarried { get; set; }

        public string Address { get; set; }

        public DateTime BirthDay { get; set; }

        public string BirthPlace { get; set; }

        public string Children { get; set; }

        public string ChurchAddress { get; set; }

        public string ChurchNameOfBaptism { get; set; }

        public string CityOfOrigin { get; set; }

        //public string CompanyName { get; set; }

        //public DateTime CreationDate { get; set; }

        public DateTime DateOfBaptism { get; set; }

        public string EmailAddress { get; set; }

        public string FieldOfService { get; set; }

        public string MentionsForChurchConfessionOfFaith { get; set; }

        public string PhoneNumber { get; set; }

        public string PlaceOfBaptism { get; set; }

        public string Profesion { get; set; }

        public int RegistrationNumber { get; set; }

        public int RequestDate { get; set; }

        public RequestStatus RequestStatus { get; set; }

        public string Resolution { get; set; }

        public string SpouseName { get; set; }

        //public int UserCreated { get; set; }

        public int YearOfConversion { get; set; }

    }
}