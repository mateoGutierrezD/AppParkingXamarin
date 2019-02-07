using System.Collections.Generic;
using ADNParking.Core.Dtos;

namespace ADNParking.Core.Repositories
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetVehicles();

        void AddVehicle(Vehicle vehicle);

        void DeleteVehicle(string plate);
    }
}
