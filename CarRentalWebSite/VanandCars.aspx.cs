using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalWebSite.CarServiceReference;
using CarRentalWebSite.VanServiceReference;

namespace CarRentalWebSite
{
    public partial class VanandCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = new VanServiceClient();
            if (DropDownList1.SelectedValue == "Van")
            {
                GridView1.DataSource = client.AvailableVan();
                GridView1.DataBind();

            }
            var client1 = new VehicleClient();
            if (DropDownList1.SelectedValue == "Car")
            {
                GridView1.DataSource =client1.AvailableCars();
                GridView1.DataBind();

            }
        }
    }
}