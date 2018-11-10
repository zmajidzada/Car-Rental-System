using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalServices;
using CarRentalWebSite.AuthServiceReference;

namespace CarRentalWebSite
{
    public partial class CustLoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNLogin_Click(object sender, EventArgs e)
        {
            var client = new AuthServiceClient();

            var customer = new CustomerModel
            {
                Email = TextBoxLogin.Text,
                Password = TextBoxPassword.Text
            };

            bool logInResult = Convert.ToBoolean(client.AuthenticateCustomer(customer));
            if (logInResult)
            {

                Response.Redirect("BookingPage.aspx");
                LabelMessage.Text = "Welcome";
            }
            else
            {
                {
                    LabelMessage.Text = "Login failed! Please enter your usename and password";
                }
            }
        }
    }
}