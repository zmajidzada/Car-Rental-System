using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;

namespace CarRentalServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVehicle" in both code and config file together.
    [ServiceContract]
    public interface IVehicle
    {
        [OperationContract]
        string InsertCar(CarModel car);
        [OperationContract]
        CarModel RetrieveCarDetails(int carId);
        [OperationContract]
        string UpdateCarDetails(int carId, CarModel car);
        [OperationContract]
        string DeleteCarRecords(int carId);
        [OperationContract]
        List<CarModel> AvailableCars();
        [OperationContract]
        int MakeBooking(int numday,int acccountId ,int carId, DateTime dateOut, DateTime dateReturn,decimal totalCost );

        [OperationContract]
       string  ModifyBooking(int bookingId);
        [OperationContract]
        string CancelBooking(int bookingId);

        [OperationContract]
        bool CheckCarAvailability(int carId);
        [OperationContract]
        int GetTotalNumberOfCar();
        [OperationContract]
        int GetTotalNumberOfCarOnRent();



    }
}