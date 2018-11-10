using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarRentalServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthService" in both code and config file together.
    [ServiceContract]
    public interface IAuthService
    {

        [OperationContract]

        Boolean RegisterCustomerDetails(CustomerModel customerModel, AddressModel customerAddressModel);

        [OperationContract]

       Boolean AuthenticateCustomer(CustomerModel customerLogin);
           [OperationContract]

        Boolean RegisterAdmin(AdminModel adminModel);

        [OperationContract]

       Boolean AuthenticateAdmin(AdminModel adminModel);
    }
}
