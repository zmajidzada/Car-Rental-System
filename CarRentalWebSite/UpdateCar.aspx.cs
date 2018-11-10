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
    public partial class UpdateCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var carModel=new CarModel();

            int carId = Convert.ToInt32(TextBoxCarId.Text);
            var client = new Car();

            carModel = client.RetrieveCarDetails(carId);

            TextBoxMake.Text = carModel.Make;
            TextBoxModel.Text = carModel.Model;
            TextBoxRegNumber.Text = carModel.RegNumber;
            TextBoxDailyRent.Text = Convert.ToString(carModel.DailyRent);
            TextBoxDescription.Text = carModel.Description;
            TextBoxIsavailable.Text = Convert.ToString(carModel.Isavailable);



        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            
            int carId = Convert.ToInt32(TextBoxCarId.Text);
            var client = new  Car();
            var carModel = new CarModel
            {

                Make = TextBoxMake.Text,
                Model = TextBoxModel.Text,
                RegNumber = TextBoxRegNumber.Text,
                DailyRent=Convert.ToDecimal(TextBoxDailyRent.Text),
                Description = TextBoxDescription.Text,
                Isavailable = Convert.ToBoolean(TextBoxIsavailable.Text)

            };

            string str = client.UpdateCarDetails(carId, carModel);
            LabelUpdateMessage.Text = str;
            TextBoxMake.Text = "";
            TextBoxModel.Text = "";
            TextBoxRegNumber.Text = "";
            TextBoxDailyRent.Text = "";
            TextBoxDescription.Text = "";
            TextBoxIsavailable.Text = "";
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            int carId = Convert.ToInt32(TextBoxCarId.Text);
            var client = new  Car();
         client.DeleteCarRecords(carId);
          
           // LabelUpdateMessage.Text = str;
        }

      
    }

   
    }
