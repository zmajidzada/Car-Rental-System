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
    public partial class RegisterCustomerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNRegister_Click(object sender, EventArgs e)
        {

            var client =new AuthServiceClient();
            var customerModel = new CustomerModel
            {
                Email = TextBoxEmail.Text,
                Password = TextBoxPassword.Text,
                FirstName = TextBoxFirstName.Text,
                LastName = TextBoxLastName.Text,
                PhoneNo = TextBoxPhoneNumber.Text,
                DateOfBirth = TextBoxDateOfBirth.Text
               

            };
            var customerAddressModel = new AddressModel
            {

                HouseNo = TextBoxHouseNumber.Text,
                StreetName = TextBoxStreetName.Text,
                Town = TextBoxTown.Text,
                PostCode = TextBoxPostCode.Text
            };

            bool result =Convert.ToBoolean(client.RegisterCustomerDetails(customerModel, customerAddressModel));
            if (result)
            {
                Response.Redirect("CustLoginPage.aspx");
            }
            else
            {
                LabelReturnMessage.Text = "User exists";
            }
            
        }

     
    }
}