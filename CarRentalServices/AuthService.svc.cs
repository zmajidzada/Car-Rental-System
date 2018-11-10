using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Caching;

namespace CarRentalServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthService.svc or AuthService.svc.cs at the Solution Explorer and start debugging.
    public class AuthService : IAuthService
    {


        public bool RegisterCustomerDetails(CustomerModel customerModel, AddressModel customerAddressModel)
        {
           

             using (
                var connection =
                    new SqlConnection(
                        "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True"))
            {
                connection.Open();

                using (
                    SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from CustomerTable where Email like @Email",
                        connection)
                    )
                {

                    sqlCommand.Parameters.AddWithValue("@Email", customerModel.Email);

                    int count = (int) sqlCommand.ExecuteScalar();


                    if (count > 0)
                    {
                        return false;
                    }
                    else
                    {

                        try
                        {

                            using (var command = new SqlCommand(
                                "INSERT INTO CustomerTable (Email,Password,FirstName,LastName,PhoneNo,DOB) VALUES (@Email,@Password,@FirstName,@LastName,@PhoneNo,@DOB) " +
                                "SELECT SCOPE_IDENTITY()", connection))
                            {
                                command.Parameters.Add(new SqlParameter("Email", customerModel.Email));
                                command.Parameters.Add(new SqlParameter("Password", customerModel.Password));
                                command.Parameters.Add(new SqlParameter("FirstName", customerModel.FirstName));
                                command.Parameters.Add(new SqlParameter("LastName", customerModel.LastName));
                                command.Parameters.Add(new SqlParameter("PhoneNo", customerModel.PhoneNo));
                                command.Parameters.Add(new SqlParameter("DOB", customerModel.DateOfBirth));
                               
                                var accountId = command.ExecuteScalar();
                                customerAddressModel.AccountId= Convert.ToInt32(accountId);
                            }
                        }

                        catch
                            (Exception)
                        {
                            throw;
                        }

                        using (var command = new SqlCommand(
                            "INSERT INTO AddressCustomer (AccountID, HouseNo, StreetName, Town, PostCode) VALUES (@AccountID, @HouseNo, @StreetName, @Town, @PostCode)" +
                            "SELECT SCOPE_IDENTITY()", connection))
                        {
                            command.Parameters.Add(new SqlParameter("AccountID", customerAddressModel.AccountId));
                            command.Parameters.Add(new SqlParameter("HouseNo", customerAddressModel.HouseNo));
                            command.Parameters.Add(new SqlParameter("StreetName", customerAddressModel.StreetName));
                            command.Parameters.Add(new SqlParameter("Town", customerAddressModel.Town));
                            command.Parameters.Add(new SqlParameter("PostCode", customerAddressModel.PostCode));

                            var addressId = command.ExecuteScalar();

                            

                        }
                        return true;
                    }
                }
               
            }
            
        }

        public bool AuthenticateCustomer(CustomerModel customerLogin)
        {


            var connection =
                new SqlConnection(
                    "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true");
            connection.Open();
            try
            {


                using (
                    SqlCommand sqlCommand =
                        new SqlCommand(
                            "SELECT COUNT(*) from CustomerTable where Email=@Email AND Password=@Password",
                            connection)
                    )
                {

                    sqlCommand.Parameters.AddWithValue("@Email", customerLogin.Email);
                    sqlCommand.Parameters.AddWithValue("@Password", customerLogin.Password);

                    int count = (int) sqlCommand.ExecuteScalar();
                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {


                throw;

            }
       
        }

        public bool RegisterAdmin(AdminModel adminModel)
        {
            using (
                var connection =
                    new SqlConnection(
                        "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True"))
            {
                connection.Open();

                using (
                    SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from AdminTable where Admin_UserName=@Admin_UserName",
                        connection)
                    )
                {

                    sqlCommand.Parameters.AddWithValue("@Admin_UserName", adminModel.AdminUserName);

                    int count = (int) sqlCommand.ExecuteScalar();


                    if (count > 0)
                    {
                        return false;
                    }
                    else
                    {

                        try
                        {

                            using (var command = new SqlCommand(
                                "INSERT INTO AdminTable (Admin_UserName,Admin_Password) VALUES (@Admin_UserName,@Admin_Password) ", connection))
                            {
                                command.Parameters.Add(new SqlParameter("Admin_UserName", adminModel.AdminUserName));
                                command.Parameters.Add(new SqlParameter("Admin_Password", adminModel.AdminPassword));
                              
                           command.ExecuteScalar();
                                
                            }
                        }

                        catch
                            (Exception)
                        {
                            throw;
                        }

                     
                        return true;
                    }
                }

            }
        }

        public Boolean AuthenticateAdmin(AdminModel adminModel)
        {

            var connection =
                   new SqlConnection(
                       "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true");
            connection.Open();
            try
            {


                using (
                    SqlCommand sqlCommand =
                        new SqlCommand(
                            "SELECT COUNT(*) from AdminTable where Admin_UserName=@Admin_UserName AND Admin_Password=@Admin_Password",
                            connection)
                    )
                {

                    sqlCommand.Parameters.AddWithValue("@Admin_UserName",adminModel.AdminUserName);
                    sqlCommand.Parameters.AddWithValue("@Admin_Password", adminModel.AdminPassword);

                    int count = (int)sqlCommand.ExecuteScalar();
                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {


                throw;

            }
        }
    }
}


       