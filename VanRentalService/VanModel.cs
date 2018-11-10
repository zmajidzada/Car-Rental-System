using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace VanRentalService
{
    public class VanModel
    {
        [DataMember(Name = "VanId", IsRequired = false)]
        public int VanId { get; set; }

        [DataMember(Name = "Make")]
        public string Make { get; set; }

        [DataMember(Name = "Model")]
        public string Model { get; set; }
        [DataMember(Name = "RegPlate")]
        public string RegPlate { get; set; }
        [DataMember(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name="DailyRent")]
        public decimal DailyRent { get; set; }

        [DataMember(Name = "Isavailable")]
        public bool Isavailable { get; set; }
    }
}