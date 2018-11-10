using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;

namespace CarRentalServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICustomerManagementService" in both code and config file together.
    [ServiceContract]
    public interface ICustomerManagementService
    {
        [OperationContract]
        Customer RetrieveCustomerDetails(int accountId);

        [OperationContract]
        string UpdateCustomerDetails(int accountId, Customer customer);

        [OperationContract]
        string DeleteDetails(int accountId);

        [OperationContract]
       
        List<CustomerModel> ListCustomer();
                [OperationContract]
               DataSet GetCusomterInfo(int accountId);
    }
}
