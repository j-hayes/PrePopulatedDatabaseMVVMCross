// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace PrePopulatedDatabase.Touch.Views
{
	partial class FirstView
	{
		[Outlet]
		MonoTouch.UIKit.UITableView BowTieTableView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton GetBowTiesButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BowTieTableView != null) {
				BowTieTableView.Dispose ();
				BowTieTableView = null;
			}

			if (GetBowTiesButton != null) {
				GetBowTiesButton.Dispose ();
				GetBowTiesButton = null;
			}
		}
	}
}
