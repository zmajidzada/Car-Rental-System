using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CarRentalServices
{
    public class ContractModel
    {
        [DataMember(Name = "ContractId",IsRequired = false)]
        public int ContractId { get; set; }
         [DataMember(Name ="BookingDate")]
        public DateTime BookingDate { get; set; }
        [DataMember(Name ="CollectionDate")]
        public DateTime CollectionDate { get; set; }
        [DataMember(Name = "ReturnDate")]
        public DateTime ReturnTime { get; set; }
       [DataMember(Name = "NumDay")]
        public int NumDay { get; set; }
       

    }
    
}