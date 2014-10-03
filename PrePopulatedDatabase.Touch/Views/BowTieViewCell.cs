
using System;
using System.Drawing;


using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using PrePopulatedDatabase.Core.Entities;

namespace PrePopulatedDatabase.Touch
{
	public partial class BowTieViewCell : MvxTableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("BowTieViewCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("BowTieViewCell");

		public BowTieViewCell (IntPtr handle) : base (handle)
		{
			this.DelayBind (() => {
				TieNameLabel.AdjustsFontSizeToFitWidth = true;
				AccentColorLabel.AdjustsFontSizeToFitWidth = true;
				PrimaryColorLabel.AdjustsFontSizeToFitWidth = true;
				RemainingStockLabel.AdjustsFontSizeToFitWidth = true;

				var set = this.CreateBindingSet<BowTieViewCell, BowTie> ();

				set.Bind (TieNameLabel).To (x => x.TieName); // eventaully make this both characters and traditional in Search Result VM
				set.Bind (AccentColorLabel).To (x => x.AccentColor);	
				set.Bind (PrimaryColorLabel).To (x => x.PrimaryColor);
				set.Bind (RemainingStockLabel).To (x => x.RemainingStock);

				set.Apply ();

			});
		}

		public static BowTieViewCell Create ()
		{
			return (BowTieViewCell)Nib.Instantiate (null, null) [0];
		}
	}
}

