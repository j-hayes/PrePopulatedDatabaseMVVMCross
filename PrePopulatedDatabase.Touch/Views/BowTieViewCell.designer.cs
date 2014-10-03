// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace PrePopulatedDatabase.Touch
{
	[Register ("BowTieViewCell")]
	partial class BowTieViewCell
	{
		[Outlet]
		MonoTouch.UIKit.UILabel AccentColorLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel Brand { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch IsClipOnSwitch { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel PrimaryColorLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel RemainingStockLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TieNameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TieNameLabel != null) {
				TieNameLabel.Dispose ();
				TieNameLabel = null;
			}

			if (PrimaryColorLabel != null) {
				PrimaryColorLabel.Dispose ();
				PrimaryColorLabel = null;
			}

			if (Brand != null) {
				Brand.Dispose ();
				Brand = null;
			}

			if (RemainingStockLabel != null) {
				RemainingStockLabel.Dispose ();
				RemainingStockLabel = null;
			}

			if (AccentColorLabel != null) {
				AccentColorLabel.Dispose ();
				AccentColorLabel = null;
			}

			if (IsClipOnSwitch != null) {
				IsClipOnSwitch.Dispose ();
				IsClipOnSwitch = null;
			}
		}
	}
}
