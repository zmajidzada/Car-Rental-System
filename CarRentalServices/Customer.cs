using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CarRentalServices
{
    [DataContract]
    public partial class Customer
    {

        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string PhoneNo { get; set; }
        [DataMember]
        public string HouseNo { get; set; }
        [DataMember]
        public string StreetName { get; set; }
        [DataMember]

        public string Town { get; set; }
        [DataMember]
        public string PostCode { get; set; }
        [DataMember(Name = "DateOfBirth")]
        public string DateOfBirth { get; set; }
    }
}