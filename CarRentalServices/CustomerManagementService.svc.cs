using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarRentalServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerManagementService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CustomerManagementService.svc or CustomerManagementService.svc.cs at the Solution Explorer and start debugging.
    public class CustomerManagementService : ICustomerManagementService
    {
        Customer customer= new Customer();

        public Customer RetrieveCustomerDetails(int accountId)
        {

            string Message = "";

            var connection =
                new SqlConnection(
                    "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true");
            connection.Open();

            using (
                SqlCommand sqlCommand =
                    new SqlCommand(
                        "SELECT COUNT(*) from CustomerTable where AccountID=@accountId",
                        connection)
                )
            {

                sqlCommand.Parameters.AddWithValue("@accountId", accountId);


                int count = (int)sqlCommand.ExecuteScalar();
                if (count == 1)
                {

                    try
                    {


                        using (var command = new SqlCommand(
                            "select * from CustomerTable where AccountID=@AccountId", connection))
                        {
                            command.Parameters.Add(new SqlParameter("AccountId", accountId));

                            var reader = command.ExecuteReader();

                            while (reader.Read())
                            {

                                {
                                    customer.AccountId = (int)reader["AccountID"];
                                    customer.Email = reader["Email"].ToString();
                                    customer.FirstName = reader["FirstName"].ToString();
                                    customer.LastName = reader["LastName"].ToString();
                                    customer.PhoneNo = reader["PhoneNo"].ToString();
                                    customer.DateOfBirth = reader["DOB"].ToString();
                                

                                }

                            }
                        }
                    }


                    catch (Exception)
                    {

                        throw;
                    }

                    try
                    {
                        using (var cmdAddress = new SqlCommand(
                            "select * from AddressCustomer where AccountID=@AccountId", connection))
                        {
                            cmdAddress.Parameters.Add(new SqlParameter("AccountId", accountId));


                            var reader = cmdAddress.ExecuteReader();
                            while (reader.Read())
                            {

                                {
                                    customer.AccountId = (int)reader["AccountID"];

                                    customer.HouseNo = reader["HouseNo"].ToString();
                                    customer.StreetName = reader["StreetName"].ToString();
                                    customer.Town = reader["Town"].ToString();
                                    customer.PostCode = reader["PostCode"].ToString();


                                }
                            }
                        }
                    }
                    catch
                        (Exception)
                    {

                        throw;
                    }
                }
            }
            return customer;
        }


        public string UpdateCustomerDetails(int accountId, Customer customer)
        {
            string message = "";
            SqlConnection connection =
                new SqlConnection("Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            connection.Open();
            try
            {
                using (
                    var cmdUpdate =
                        new SqlCommand(
                            "UPDATE CustomerTable SET Email=@Email, FirstName =@FirstName, LastName =@LastName, PhoneNo=@PhoneNo,DOB=@DOB WHERE AccountID =@AccountId;UPDATE AddressCustomer SET HouseNo=@HouseNo,  StreetName=@StreetName, Town=@Town, PostCode=@PostCode WHERE AccountID =@AccountId", connection))
                {


                    cmdUpdate.Parameters.Add("@Email", SqlDbType.VarChar).Value = customer.Email;
                    cmdUpdate.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = customer.FirstName;
                    cmdUpdate.Parameters.Add("@LastName", SqlDbType.VarChar).Value = customer.LastName;
                    cmdUpdate.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = customer.PhoneNo;
                    cmdUpdate.Parameters.Add("@DOB", SqlDbType.Date).Value = customer.DateOfBirth;
                    // cmdUpdate.Parameters.Add("@AccountID", SqlDbType.Int).Value = accountId;


                    cmdUpdate.Parameters.Add("@HouseNo", SqlDbType.VarChar).Value = customer.HouseNo;
                    cmdUpdate.Parameters.Add("@StreetName", SqlDbType.VarChar).Value = customer.StreetName;
                    cmdUpdate.Parameters.Add("@Town", SqlDbType.VarChar).Value = customer.Town;
                    cmdUpdate.Parameters.Add("@PostCode", SqlDbType.VarChar).Value = customer.PostCode;
                   
                
                    cmdUpdate.Parameters.Add("@AccountID", SqlDbType.Int).Value = accountId;
                    // cmdUpdate.Parameters.Add("@PostCode", SqlDbType.VarChar).Value = customer.PostCode;
                    //   cmdUpdate.Parameters Add(new SqlParameter("Email",cust.Email));

                    // customer.AccountId = Convert.ToInt32(accountId);
                    //      var aa= cmdUpdate.ExecuteScalar();
                    accountId= cmdUpdate.ExecuteNonQuery();
                    message = "Account has been updated";
                }

            }
            catch (Exception)
            {
                throw;
            }


            return message;
        }

        public string DeleteDetails(int accountId)
        {
            string confirmMessage = " Account has been deleted";
            SqlConnection connection = new SqlConnection("Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            connection.Open();


            try
            {
                using (
                    var deleteAddressCommand =
                        new SqlCommand(
                            "Delete from AddressCustomer WHERE AccountID =@AccountId",
                            connection))
                {
                    deleteAddressCommand.Parameters.Add(new SqlParameter("AccountID", accountId));
                    var reader = deleteAddressCommand.ExecuteReader();

                    while (reader.Read())
                    {


                    }
                    reader.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                using (
                    var deleteCommand =
                        new SqlCommand(
                            "Delete from CustomerTable WHERE AccountID =@AccountId",
                            connection))
                {
                    deleteCommand.Parameters.Add(new SqlParameter("AccountID", accountId));
                    var reader = deleteCommand.ExecuteReader();

                    while (reader.Read())
                    {


                    }
                    // reader.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return confirmMessage;
        }

        public List<CustomerModel> ListCustomer()
        {

            List<CustomerModel> customers = new List<CustomerModel>();

            var connection =
                new SqlConnection(
                    "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true");
            connection.Open();

            using (
                SqlCommand command =
                    new SqlCommand(
                        "SELECT AccountID, Email,FirstName,LastName,PhoneNo,DOB from CustomerTable",
                        connection)
                )
            {

                var reader = command.ExecuteReader();

                while (reader.Read())
                {

                    {
                    var customerModel= new CustomerModel();
                        customerModel.CustomerId =Convert.ToInt32( reader["AccountID"].ToString());
                    customerModel.Email = reader["Email"].ToString();
                    customerModel.FirstName = reader["FirstName"].ToString();
                    customerModel.LastName = reader["LastName"].ToString();
                     customerModel.PhoneNo = reader["PhoneNo"].ToString();
                     customerModel .DateOfBirth= reader["DOB"].ToString();

                     customers.Add(customerModel);

                    }
                }
            }


            return customers;
        
        }

        public DataSet GetCusomterInfo(int accountId)
       {
           DataSet dt = new DataSet();
            var connection =
               new SqlConnection(
                   "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true");
            connection.Open();

           using (var command = new SqlCommand(
               "select Email,FirstName,LastName,PhoneNo, DATEDIFF(YEAR,DOB,GETDATE()) from CustomerTable where AccountID=@AccountId;select HouseNo,StreetName,Town,PostCode from AddressCustomer where AccountID=@AccountId", connection))
           {
               command.Parameters.Add(new SqlParameter("AccountId", accountId));
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(dt);

           }
           return dt;
        }
    }
}
