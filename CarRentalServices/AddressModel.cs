using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CarRentalServices
{
    [DataContract]
    public class AddressModel
    {
        [DataMember(Name = "AddressId", IsRequired = false)]
        public int AccountId{ get; set; }

        [DataMember(Name = "HouseNo")]
        public string HouseNo { get; set; }

        [DataMember(Name = "StreetName")]
        public string StreetName { get; set; }

        [DataMember(Name = "Town")]
        public string Town { get; set; }

        [DataMember(Name = "PostCode")]
        public string PostCode { get; set; }



      
    }
}