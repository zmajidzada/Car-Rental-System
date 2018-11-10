using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace VanRentalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVanService" in both code and config file together.
    [ServiceContract]
    public interface IVanService
    {


        [OperationContract]
        string InsertVan(VanModel vanModel);
        [OperationContract]
        List<VanModel> AvailableVan();
    }
}
