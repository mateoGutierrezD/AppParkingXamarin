// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AppParking.Touch.ViewControllers
{
    [Register ("VehiclesViewController")]
    partial class VehiclesViewController
    {
        [Outlet]
        UIKit.UILabel titleLabel { get; set; }


        [Outlet]
        UIKit.UITableView vehiclesTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (titleLabel != null) {
                titleLabel.Dispose ();
                titleLabel = null;
            }

            if (vehiclesTableView != null) {
                vehiclesTableView.Dispose ();
                vehiclesTableView = null;
            }
        }
    }
}