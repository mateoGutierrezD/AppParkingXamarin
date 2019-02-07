using System;
using System.Collections.Generic;
using ADNParking.Core.Domain;
using ADNParking.Core.Dtos;
using AppParking.Touch.Cells;
using AppParking.Touch.Sources;
using UIKit;

namespace AppParking.Touch.ViewControllers
{
    public partial class VehiclesViewController : UIViewController
    {
        private readonly VehicleDomain vehicleDomain = new VehicleDomain();

        public VehiclesViewController() : base("VehiclesViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            RegisterCell();
            ShowVehicles();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void RegisterCell()
        {
            vehiclesTableView.RegisterNibForCellReuse(UINib.FromName(VehicleCell.Key, null), VehicleCell.Key);
        }

        private void ShowVehicles()
        {
            List<Vehicle> vehicles = this.vehicleDomain.FetchVehicles();
            vehiclesTableView.Source = new VehiclesTableViewDataSource(vehicles);
            vehiclesTableView.ReloadData();
        }
    }
}

