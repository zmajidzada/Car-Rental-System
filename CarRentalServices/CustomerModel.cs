using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CarRentalServices
{
    [DataContract]
    public class CustomerModel
    {


       
        [DataMember(Name = "AccountId",IsRequired = false)]
        public int CustomerId { get; set; }

        [DataMember(Name="Email")]
        public string Email { get; set; }
        [DataMember (Name="Password")]
        public string Password { get; set; }
        [DataMember (Name="FirstName")]
        public string FirstName { get; set; }

        [DataMember(Name="LastName")]
        public string LastName { get; set; }
        [DataMember(Name="PhoneNo")]
        public string PhoneNo { get; set; }
        [DataMember(Name = "DateOfBirth")]
        public string DateOfBirth { get; set; }


      
    }
}
