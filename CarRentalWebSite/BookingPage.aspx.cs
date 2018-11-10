using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CarRentalServices;
using CarRentalWebSite.CustomerManagementServiceReference;
using CarRentalWebSite.CarServiceReference;

namespace CarRentalWebSite
{
    public partial class ViewCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                GetData();

            }
        }
        public void GetData(){


        var client = new Car();
            GridView1.DataSource = client.AvailableCars();
            GridView1.DataBind();
            
          //  List<CarModel>cars=new List<CarModel>();
          //  cars = client.AvailableCars();
         //   Response.Write("<a href="""+theUrl+""">"+theUrl+"</a>")

         //   foreach (var result in cars)
         //   {
          //      Response.Write(result.Make+result.Model+result.RegNumber+"<a href='gooogle.com'/?result.CarID>Book</a>");
         //   }

           // <a href="/Home/Delete/?stuId=@item.Id">Delete</a>}
        }

      
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            var today = DateTime.Now;
            TextBoxBookingDate.Text = today.ToString("dd-MMM-yyyy");
            var client = new CustomerManagementServiceClient();
            DataSet ds = new DataSet();
            int data = Convert.ToInt32(TextBoxAccountID.Text);
            ds = client.GetCusomterInfo(data);

            TextBoxEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            TextBoxFirstName.Text =  ds.Tables[0].Rows[0]["FirstName"].ToString();
            TextBoxLastName.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
            TextBoxPhoneNo.Text = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
            TextBoxAge.Text = ds.Tables[0].Rows[0]["Column1"].ToString();
            TextBoxHouseNo.Text = ds.Tables[1].Rows[0]["HouseNo"].ToString();
            TextBoxStreetName.Text = ds.Tables[1].Rows[0]["StreetName"].ToString();
            TextBoxTown.Text = ds.Tables[1].Rows[0]["Town"].ToString();
            TextBoxPostCode.Text = ds.Tables[1].Rows[0]["PostCode"].ToString();
        }

        protected void ButtonCarSearch_Click(object sender, EventArgs e)
        {
            int carId = Convert.ToInt32(TextBoxCarId.Text);
            var carModel = new CarModel();
             var checkClient=new Car();


            bool result = Convert.ToBoolean(checkClient.CheckCarAvailability(carId));
            if (result)
            {
                var client = new Car();

                carModel = client.RetrieveCarDetails(carId);

                TextBoxMake.Text = carModel.Make;
                TextBoxModel.Text = carModel.Model;
                TextBoxRegistration.Text = carModel.RegNumber;
                TextBoxDailyPrice.Text = Convert.ToString(carModel.DailyRent);
                TextBoxDescription.Text = carModel.Description;
                LabelTotal.Text = "";

            }

            else
            {
                LabelTotal.Text = "Either you have entered incorrect car id or the car is not available for rent";
            }

        }

        protected void ButtonBook_Click(object sender, EventArgs e)
        {
            int accountId = Convert.ToInt32(TextBoxAccountID.Text);
              int carId = Convert.ToInt32(TextBoxCarId.Text);
            int totalCost=0;
            int age;

            DateTime startdate;
            DateTime enddate;
            startdate = DateTime.Parse(TextBoxCollectionDate.Text).Date;
            enddate = DateTime.Parse(TextBoxReturnDate.Text).Date;
            TimeSpan t = enddate - startdate;
            double TotalNumDay = t.TotalDays;
            TextBoxNumDay.Text = Convert.ToString(TotalNumDay);
            int numDay = Convert.ToInt32(TotalNumDay);
            int pricePerDay = Convert.ToInt32(TextBoxDailyPrice.Text);
            age = Convert.ToInt32(TextBoxAge.Text);
            if (age<25)
            {


                totalCost = pricePerDay*numDay+20;
            }
            if (age > 70)
            {


                totalCost = pricePerDay*numDay + 25;
            }
            else
            {
                totalCost = pricePerDay*numDay;
            }

            TextBoxTotalCost.Text = Convert.ToString(totalCost);
            //   LabelResult.Text = Convert.ToString(TotalDays);
            
             var client = new Car();
             int bookingId =client.MakeBooking(numDay, accountId, carId, startdate, enddate, totalCost);
             TextBoxBookingID.Text = Convert.ToString(bookingId);

        }
    }
}