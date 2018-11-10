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
    public partial class RegisterCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                  if (Session["AdminUser"] != null)
            {
                LabelSession.Text = Session["AdminUser"].ToString();
            }
        
            var client = new VehicleClient();
             int totalCars=client.GetTotalNumberOfCar();
            LabelAvailableCars.Text = Convert.ToString(totalCars);
            int totalCarOnRent = client.GetTotalNumberOfCarOnRent();
            LabelTotalCarOnRent.Text = Convert.ToString(totalCarOnRent);
        }
        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            var client = new VehicleClient();
        

            var car = new CarModel
            {
                Make = TextBoxMake.Text,
                Model = TextBoxModel.Text,
                RegNumber = TextBoxRegNumber.Text,
                DailyRent = Convert.ToDecimal(TextBoxDailyRent.Text),
                Description = TextBoxDescription.Text,
                Isavailable = Convert.ToBoolean(TextBoxIsavailable.Text)

            };
            string returnMessage=client.InsertCar(car);
            LabelMessage.Text = returnMessage;
            TextBoxMake.Text = "";
            TextBoxModel.Text = "";
            TextBoxRegNumber.Text = "";
            TextBoxDailyRent.Text = "";
            TextBoxDescription.Text = "";
            TextBoxIsavailable.Text = "";

        }
    }


}