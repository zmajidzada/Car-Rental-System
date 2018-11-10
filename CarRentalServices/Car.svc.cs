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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Car" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Car.svc or Car.svc.cs at the Solution Explorer and start debugging.
    public class Car : IVehicle
    {

        public string InsertCar(CarModel carModel)
        {
            string Message = "";
            using (
                var connection =
                    new SqlConnection(
                        "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True"))
            {
                connection.Open();

                using (
                    SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from CarTable where RegNumber like @RegNumber",
                        connection)
                    )
                {

                    sqlCommand.Parameters.AddWithValue("@RegNumber", carModel.RegNumber);

                    int count = (int) sqlCommand.ExecuteScalar();


                    if (count > 0)
                    {
                        Message = "car already exists";
                    }
                    else
                    {

                        try
                        {

                            using (var command = new SqlCommand(
                                "INSERT INTO CarTable (Make,Model,RegNumber,Daily_Rent,Description,Isavailable) VALUES (@Make,@Model,@RegNumber,@Daily_Rent,@Description,@Isavailable)",
                                connection))
                            {
                                command.Parameters.Add(new SqlParameter("Make", carModel.Make));
                                command.Parameters.Add(new SqlParameter("Model", carModel.Model));
                                command.Parameters.Add(new SqlParameter("RegNumber", carModel.RegNumber));
                                command.Parameters.Add(new SqlParameter("Daily_Rent", carModel.DailyRent));
                                command.Parameters.Add(new SqlParameter("Description", carModel.Description));
                                command.Parameters.Add(new SqlParameter("Isavailable", carModel.Isavailable));
                                command.ExecuteScalar();
                                Message = "Car added to the system";
                            }
                        }

                        catch
                            (Exception)
                        {
                            throw;
                        }

                    }

                }
                return Message;   
            }
        }


        public CarModel RetrieveCarDetails(int carId)
        {

           
            string Message = "";

            CarModel carModel=new CarModel();

            var connection =
                new SqlConnection(
                    "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true");
            connection.Open();

            using (
                SqlCommand sqlCommand =
                    new SqlCommand(
                        "SELECT COUNT(*) from CarTable where CarID=@carId",
                        connection)
                )
            {

                sqlCommand.Parameters.AddWithValue("@carId", carId);


                int count = (int) sqlCommand.ExecuteScalar();
                if (count == 1)
                {

                    try
                    {


                        using (var command = new SqlCommand(
                            "select * from CarTable where CarID=@carId", connection))
                        {
                            command.Parameters.Add(new SqlParameter("carId", carId));

                            var reader = command.ExecuteReader();

                            while (reader.Read())
                            {

                                {

                                    carModel.Make = reader["Make"].ToString();
                                    carModel.Model = reader["Model"].ToString();
                                    carModel.RegNumber = reader["RegNumber"].ToString();
                                    carModel.DailyRent =Convert.ToDecimal(reader["Daily_Rent"].ToString());
                                    carModel.Description = reader["Description"].ToString();
                                    carModel.Isavailable =Convert.ToBoolean(reader["Isavailable"].ToString());


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
                return carModel;
               
        }


        public string UpdateCarDetails(int carId, CarModel car)
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
                            "UPDATE CarTable SET Make=@Make, Model =@Model, RegNumber=@RegNumber, Daily_Rent=@Daily_Rent,Description=@Description,Isavailable=@Isavailable WHERE CarID =@carId", connection))
                {
                   

                    cmdUpdate.Parameters.Add("@Make",SqlDbType.VarChar).Value=car.Make;
                    cmdUpdate.Parameters.Add("@Model", SqlDbType.VarChar).Value =car.Model;
                    cmdUpdate.Parameters.Add("@RegNumber", SqlDbType.VarChar).Value =car.RegNumber;
                    cmdUpdate.Parameters.Add("@carId", SqlDbType.Int).Value = carId;
                    cmdUpdate.Parameters.Add("@Daily_Rent", SqlDbType.Decimal).Value = car.DailyRent;
                    cmdUpdate.Parameters.Add("@Description",SqlDbType.VarChar).Value= car.Description;
                    cmdUpdate.Parameters.Add("@Isavailable", SqlDbType.Bit).Value = car.Isavailable;

                    cmdUpdate.ExecuteNonQuery();
                    message = "Record has been updated";
                }

            }
            catch (Exception)
            {
                throw;
            }
          

            return message;
        }
        


        public string DeleteCarRecords(int carId)
        {
                       string confirmMessage = " Record has been deleted";
            SqlConnection connection=new SqlConnection("Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            connection.Open();

          
            try
            {
                using (
                    var deleteAddressCommand =
                        new SqlCommand(
                            "Delete from CarTable WHERE CarID =@carId",
                            connection))
                {
                    deleteAddressCommand.Parameters.Add(new SqlParameter("carId", carId));
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


            return confirmMessage;
        
        }

        public List<CarModel> AvailableCars()

        {


            List<CarModel> cars = new List<CarModel>();

            var connection =
                new SqlConnection(
                    "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true");
            connection.Open();

            using (
                SqlCommand command =
                    new SqlCommand(
                        "SELECT CarID, Make,Model,RegNumber,Daily_Rent,Description,Isavailable from CarTable",
                        connection)
                )
            {

                var reader = command.ExecuteReader();

                while (reader.Read())
                {

                    {
                    var car = new CarModel();
                        car.Make = reader["Make"].ToString();
                        car.Model = reader["Model"].ToString();
                        car.RegNumber = reader["RegNumber"].ToString();
                        car.DailyRent = Convert.ToDecimal(reader["Daily_Rent"].ToString());
                        car.Description = reader["Description"].ToString();
                        car.CarId = Convert.ToInt32(reader["CarID"].ToString());
                        car.Isavailable =Convert.ToBoolean( reader["Isavailable"].ToString());

                        cars.Add(car);

                    }
                }
            }
     

    return cars;
        }

        public int MakeBooking(int numDay, int accountId,int carId, DateTime dateOut, DateTime dateReturn,decimal totalCost )
        {
            int bookingId = 0;
            var bookingDate = DateTime.Now;
            SqlConnection connection = new SqlConnection("Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            connection.Open();
            using (var command = new SqlCommand(
                "INSERT INTO ContractTable (AccountID,CarID,Car_Collection_Date,Car_Return_Date,numDay,BookingDate,TotalCost) VALUES (@AccountID,@CarID,@Car_Collection_Date,@Car_Return_Date,@numday,@BookingDate,@TotalCost)", connection))
            {
                command.Parameters.Add(new SqlParameter("AccountID", accountId));
                command.Parameters.Add(new SqlParameter("CarID", carId));
                command.Parameters.Add(new SqlParameter("Car_Collection_Date", dateOut));
                command.Parameters.Add(new SqlParameter("Car_Return_Date", dateReturn));
                command.Parameters.Add(new SqlParameter("NumDay", numDay));
                command.Parameters.Add(new SqlParameter("BookingDate", bookingDate));
                command.Parameters.Add(new SqlParameter("TotalCost", totalCost));
               command.ExecuteScalar();
            }

            using (
                    var cmdUpdate =
                        new SqlCommand(
                            "UPDATE CarTable SET Isavailable=0 WHERE CarID =@carId", connection))
                {
                   
                    cmdUpdate.Parameters.Add(new SqlParameter("CarID", carId));

                    cmdUpdate.ExecuteNonQuery();
                  
                }


            using (
                var cmd = new SqlCommand("select ContractId from ContractTable where AccountID=accountId", connection))
            {
                cmd.Parameters.Add(new SqlParameter("AccountID", accountId));


                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bookingId =Convert.ToInt32( reader["ContractId"].ToString());
                }
            }
            return bookingId;

         
        }

        public bool CheckCarAvailability(int carId)
        {
          
            var connection =
                new SqlConnection(
                    "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true");
            connection.Open();

                        using (
                SqlCommand sqlCommand =
                    new SqlCommand(
                        "SELECT COUNT(*) from CarTable where CarID=@carId and Isavailable=1",
                        connection)
                )
            {

                sqlCommand.Parameters.AddWithValue("@carId", carId);


                int count = (int) sqlCommand.ExecuteScalar();
                if (count == 1)
                {

                    return true;


                }
                
                return false;
                }
        }


        public string ModifyBooking(int bookingId)
        {

            return null;
        }

        public int GetTotalNumberOfCar()
        {

            int count = 0;
   

               var connection =
                new SqlConnection(
                    "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true");
            connection.Open();

                    using (var cmdCount = new SqlCommand("SELECT COUNT(*) from CarTable", connection))
                    {
                     
                        count = (int)cmdCount.ExecuteScalar();
                    }



                    return count;
            
        }

       public int GetTotalNumberOfCarOnRent()
        {
            int count = 0;


            var connection =
             new SqlConnection(
                 "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true");
            connection.Open();

            using (var cmdCount = new SqlCommand("SELECT COUNT(*) from CarTable where Isavailable=0", connection))
            {

                count = (int)cmdCount.ExecuteScalar();
            }



            return count;
        }

        public string CancelBooking(int bookingId)
        {
            string confirmMessage = " Your have cancelled your booking";
            SqlConnection connection =
                new SqlConnection("Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            connection.Open();


            try
            {
                using (
                    var deleteAddressCommand =
                        new SqlCommand(
                            "Delete from ContractTable WHERE ContractId =@ContractId",
                            connection))
                {
                    deleteAddressCommand.Parameters.Add(new SqlParameter("ContractId", bookingId));
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


            return confirmMessage;
        
        }

     

    }
}
   