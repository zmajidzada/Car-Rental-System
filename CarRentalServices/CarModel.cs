using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CarRentalServices
{
    [DataContract]
    public class CarModel
    {
        [DataMember(Name = "CarID", IsRequired = false)]
        public int CarId { get; set; }

        [DataMember(Name = "Make")]
        public string Make{ get; set; }


        [DataMember(Name = "Model")]

        public string Model { get; set; }

        [DataMember(Name = "RegNumber")]

        public string RegNumber { get; set; }

        [DataMember(Name = "Description")]
       public string Description { get; set; }
       [DataMember(Name = "DailyRent")]
      public decimal DailyRent { get; set; }
        [DataMember(Name = "Isavailable")]
       public bool Isavailable { get; set; }


    }
}