using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VanRentalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IVanService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IVanService.svc or IVanService.svc.cs at the Solution Explorer and start debugging.
    public class Van : IVanService
    {

        public string InsertVan(VanModel vanModel)
        {

            using (var connection = new SqlConnection(
                "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true")
                )
            connection.Open();

            using (var command = new SqlCommand("Insert Into VanTable(Make,Model,RegPlate,Description,Daily,Isavailable)values(@Make,@Model,@RegPlate,@Description,@DailyPrice,@Isavailable)"))
            {
                command.Parameters.Add(new SqlParameter("Make", vanModel.Make));
                command.Parameters.Add(new SqlParameter("Model", vanModel.Model));
                command.Parameters.Add(new SqlParameter("RegPlate", vanModel.RegPlate));
                command.Parameters.Add(new SqlParameter("Description", vanModel.Description));
                command.Parameters.Add(new SqlParameter("DailyRent", vanModel.DailyRent));
                command.Parameters.Add(new SqlParameter("Isavailable", vanModel.Isavailable));
                command.ExecuteScalar();
                

            }
            return "Car added";
        }

        public List<VanModel> AvailableVan()
        {
            var vans = new List<VanModel>();
            var connection = new SqlConnection(
                "Data Source=SAMAH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=true");
              
                connection.Open();
            using (var cmd = new SqlCommand("Select Make,Model,RegPlate,Description,DailyRent,Isavailable from VanTable ",connection))
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var van = new VanModel
                    {
                        Make = reader["Make"].ToString(),
                        Model = reader["Model"].ToString(),
                        RegPlate = reader["RegPlate"].ToString(),
                        Description = reader["Description"].ToString(),
                        DailyRent = Convert.ToInt32(reader["DailyRent"].ToString()),
                        Isavailable = Convert.ToBoolean(reader["Isavailable"].ToString())

                      
                    };
                    vans.Add(van);
                }
            }


            return vans;
        }
    }
}
