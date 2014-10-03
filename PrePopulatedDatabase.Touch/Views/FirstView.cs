using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using Cirrious.MvvmCross.Binding.Touch.Views;
using PrePopulatedDatabase.Core.ViewModels;

namespace PrePopulatedDatabase.Touch.Views
{
    [Register("FirstView")]
    public partial class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
			if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
				EdgesForExtendedLayout = UIRectEdge.None;

            base.ViewDidLoad();

			var source = new MvxSimpleTableViewSource (BowTieTableView, BowTieViewCell.Key, BowTieViewCell.Key);
			BowTieTableView.Source = source;

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();

			set.Bind (source).To (ViewModel => ViewModel.BowTies);
			set.Bind (GetBowTiesButton).To (ViewModel => ViewModel.GetBowtiesCommand);


			set.Apply();

			//((FirstViewModel)this.ViewModel).GetBowtiesCommand.Execute(null);


			BowTieTableView.ReloadData ();
        }
    }
}