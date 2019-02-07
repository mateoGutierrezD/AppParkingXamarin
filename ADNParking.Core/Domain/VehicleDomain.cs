using System;
using System.Collections.Generic;
using ADNParking.Core.Dtos;
using ADNParking.Core.Repositories;
using ADNParking.Core.Repositories.Implementations.Remote;

namespace ADNParking.Core.Domain
{
    public class VehicleDomain
    {

        private readonly IVehicleRepository vehicleRepository;

        public VehicleDomain()
        {
            vehicleRepository = new VehicleRepository();
        }

        public List<Vehicle>  FetchVehicles()
        {
            return vehicleRepository.GetVehicles();
        }
    }
}
