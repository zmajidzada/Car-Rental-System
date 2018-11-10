using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalServices;
using CarRentalWebSite.CustomerManagementServiceReference;
namespace CarRentalWebSite
{
    public partial class CustomerManagementPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

 
        protected void BTNSearch_Click(object sender, EventArgs e)
        {
           
            var client =new CustomerManagementServiceClient();
            int accountId =Convert.ToInt32(TextBoxAccountId.Text);
           var customer = new Customer();
            customer = client.RetrieveCustomerDetails(accountId);
            TextBoxEmail.Text = customer.Email;
            TextBoxFirstName.Text = customer.FirstName;
            TextBoxLastName.Text = customer.LastName;
            TextBoxPhoneNo.Text = customer.PhoneNo;
            TextBoxDateOfBirth.Text = customer.DateOfBirth;
            TextBoxHouseNo.Text = customer.HouseNo;
            TextBoxStreetName.Text = customer.StreetName;
            TextBoxTown.Text = customer.Town;
            TextBoxPostCode.Text = customer.PostCode;

        }
        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {

              var accountId = Convert.ToInt32(TextBoxAccountId.Text);
        var client = new CustomerManagementServiceClient();
        var customer = new Customer()
        {
            Email = TextBoxEmail.Text,
            FirstName = TextBoxFirstName.Text,
            LastName = TextBoxLastName.Text,
            PhoneNo =TextBoxPhoneNo.Text,
            DateOfBirth = TextBoxDateOfBirth.Text,
            HouseNo = TextBoxHouseNo.Text,
            StreetName = TextBoxStreetName.Text,
            Town = TextBoxTown.Text,
            PostCode = TextBoxPostCode.Text

            
        };

      
            string message = client.UpdateCustomerDetails(accountId,customer);
            LabelReturnMessage.Text = message;
            TextBoxEmail.Text = "";
            TextBoxFirstName.Text = "";
            TextBoxLastName.Text = "";
            TextBoxPhoneNo.Text = "";
            TextBoxDateOfBirth.Text = "";
            TextBoxHouseNo.Text = "";
            TextBoxStreetName.Text = "";
            TextBoxTown.Text = "";
            TextBoxPostCode.Text = "";
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            var client = new CustomerManagementServiceClient();
            int accountId = Convert.ToInt32(TextBoxAccountId.Text);
            string deleteMessage = client.DeleteDetails(accountId);
            LabelReturnMessage.Text = deleteMessage;
            TextBoxEmail.Text = "";
            TextBoxFirstName.Text = "";
            TextBoxLastName.Text = "";
            TextBoxPhoneNo.Text = "";
            TextBoxDateOfBirth.Text = "";
            TextBoxHouseNo.Text = "";
            TextBoxStreetName.Text = "";
            TextBoxTown.Text = "";
            TextBoxPostCode.Text = "";

        }
    }

 

   
}