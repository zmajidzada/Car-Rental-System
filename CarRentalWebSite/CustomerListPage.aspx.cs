using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalWebSite.CustomerManagementServiceReference;

namespace CarRentalWebSite
{
    public partial class CustomerListPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var client = new CustomerManagementServiceClient();
            GridView1.DataSource = client.ListCustomer();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}