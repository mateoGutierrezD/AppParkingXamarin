// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AppParking.Touch.Cells
{
    [Register ("VehicleCell")]
    partial class VehicleCell
    {
        [Outlet]
        UIKit.UILabel dateInLabel { get; set; }


        [Outlet]
        UIKit.UILabel hourTitleLabel { get; set; }


        [Outlet]
        UIKit.UILabel ownerLabel { get; set; }


        [Outlet]
        UIKit.UILabel plateLabel { get; set; }


        [Outlet]
        UIKit.UILabel typeVehicleLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (dateInLabel != null) {
                dateInLabel.Dispose ();
                dateInLabel = null;
            }

            if (hourTitleLabel != null) {
                hourTitleLabel.Dispose ();
                hourTitleLabel = null;
            }

            if (ownerLabel != null) {
                ownerLabel.Dispose ();
                ownerLabel = null;
            }

            if (plateLabel != null) {
                plateLabel.Dispose ();
                plateLabel = null;
            }

            if (typeVehicleLabel != null) {
                typeVehicleLabel.Dispose ();
                typeVehicleLabel = null;
            }
        }
    }
}