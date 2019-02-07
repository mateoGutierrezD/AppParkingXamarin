using System.Collections.Generic;
using ADNParking.Core.Dtos;

namespace ADNParking.Core.Repositories.Implementations.Remote
{
    public class VehicleRepository : IVehicleRepository
    {
        public List<Vehicle> GetVehicles()
        {
            var vehicle = new Vehicle
            {
                VehicleTypeCode = 1,
                VehicleTypeDescription = "Carro",
                Owner = "Mateo Gutiérrez",
                Plate = "VJY65D",
                Cylinder = 0,
                DateIn = "01/01/2019 06:00:33 a. m."
            };

            var vehicles = new List<Vehicle>();
            vehicles.Add(vehicle);

            return vehicles;
        }

        public void AddVehicle(Vehicle vehicle)
        {

        }

        public void DeleteVehicle(string plate)
        {

        }
    }
}
