using System;
namespace ADNParking.Core.Dtos
{
    public class Vehicle
    {
        public int VehicleTypeCode { get; set; }

        public string Plate { get; set; }

        public string Owner { get; set; }

        public int Cylinder { get; set; }

        public string DateIn { get; set; }

        public string VehicleTypeDescription { get; set; }
    }
}
