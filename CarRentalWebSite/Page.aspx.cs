using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalServices;
using CarRentalWebSite.CarServiceReference;

namespace CarRentalWebSite
{
    public partial class Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUser"] != null)
            {
                Label1.Text = Session["AdminUser"].ToString();
            }
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            var client = new VehicleClient();
                
            var carModel = new CarModel
            {
                Make = TextBoxMake.Text,
                Model = TextBoxModel.Text,
                RegNumber = TextBoxRegNumber.Text
            };
          string str=  client.InsertCar(carModel);
            LabelMessage.Text = str;
            TextBoxMake.Text = "";
            TextBoxModel.Text = "";
            TextBoxRegNumber.Text="";
        }
    }
}