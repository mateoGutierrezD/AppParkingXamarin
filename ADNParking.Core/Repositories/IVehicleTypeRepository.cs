using System.Collections.Generic;
using ADNParking.Core.Dtos;

namespace ADNParking.Core.Repositories
{
    public interface IVehicleTypeRepository
    {
        List<VehicleTypes> GetVehicleTypes();
    }
}
