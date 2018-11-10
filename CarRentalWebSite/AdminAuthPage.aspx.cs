using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CarRentalServices;
using CarRentalWebSite.AuthServiceReference;

namespace CarRentalWebSite
{
    public partial class AdminAuthPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextBoxRegisterUserName.Text) ||
                string.IsNullOrEmpty(this.TextBoxRegisterPassword.Text))
            {
                MessageBox.Show("Please provide username and password");
            }
            else
            {
                var client = new AuthServiceClient();
                var adminModel = new AdminModel
                {
                    AdminUserName = TextBoxRegisterUserName.Text,
                    AdminPassword = TextBoxRegisterPassword.Text
                };
                bool result = Convert.ToBoolean(client.RegisterAdmin(adminModel));
                if (result)
                {
                    LabelMSG.Text = "You have been registered";
                }
                else
                {
                    LabelMSG.Text = "Admin already exists";
                }
            }
        }

        protected void ButtonLogIn_Click(object sender, EventArgs e)
        {
             var client = new AuthServiceClient();
            var adminModel = new AdminModel
            {
                AdminUserName = TextBoxLoginUsername.Text,
                AdminPassword = TextBoxLoginPassword.Text
            };
            bool result = Convert.ToBoolean(client.AuthenticateAdmin(adminModel));
            if (result)
            {
                Session["AdminUser"] = "Hi "+TextBoxLoginUsername.Text;
                Response.Redirect("AddCarPage.aspx");
            }
            else
            {
                MessageBox.Show("Please provide a valid username and password");
            }
        }

        }
    }
