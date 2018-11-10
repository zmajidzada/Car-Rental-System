using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalWebSite.CarServiceReference;

namespace CarRentalWebSite
{
    public partial class CancelBookingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            int bookingId = Convert.ToInt32(TextBoxBookingID.Text);
            var client = new VehicleClient();
            string data = client.CancelBooking(bookingId);
            LabelCancel.Text = data;
        }
    }
}