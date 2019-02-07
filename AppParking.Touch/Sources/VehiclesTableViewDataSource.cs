using System;
using System.Collections.Generic;
using ADNParking.Core.Dtos;
using AppParking.Touch.Cells;
using Foundation;
using UIKit;

namespace AppParking.Touch.Sources
{
    public class VehiclesTableViewDataSource: UITableViewSource
    {
        private readonly List<Vehicle> vehicles;

        public VehiclesTableViewDataSource(List<Vehicle> vehicles) 
        {
            this.vehicles = vehicles;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var vehicleCell = tableView.DequeueReusableCell(identifier: VehicleCell.Key) as VehicleCell;
           // VehicleCell vehicleCell = tableView.DequeueReusableCell("VehicleCell", indexPath) as VehicleCell;

            vehicleCell.SetData(vehicles[indexPath.Row]);
            return vehicleCell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return vehicles.Count;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 100;
        }

    }
}
