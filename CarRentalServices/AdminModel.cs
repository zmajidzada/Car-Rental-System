using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CarRentalServices
{
    public class AdminModel
    {
        [DataMember(Name = "AdminUserName", IsRequired = false)]
        public string AdminUserName { get; set; }

        [DataMember(Name="AdminPassword")]
        public string AdminPassword { get; set; }

    }
}