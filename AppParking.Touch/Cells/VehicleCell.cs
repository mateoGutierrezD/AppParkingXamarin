using System;
using ADNParking.Core.Dtos;
using ADNParking.Core.Resources;
using Foundation;
using UIKit;

namespace AppParking.Touch.Cells
{
    public partial class VehicleCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("VehicleCell");
        public static readonly UINib Nib;
        private Vehicle vehicle;

        static VehicleCell()
        {
            Nib = UINib.FromName("VehicleCell", NSBundle.MainBundle);
        }

        public VehicleCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public void SetData(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            ownerLabel.Text = vehicle.Owner;
            typeVehicleLabel.Text = vehicle.VehicleTypeDescription;
            plateLabel.Text = vehicle.Plate;
            hourTitleLabel.Text = VehicleStrings.TitleHourInLabel;
            dateInLabel.Text = vehicle.DateIn;
        }
    }
}
