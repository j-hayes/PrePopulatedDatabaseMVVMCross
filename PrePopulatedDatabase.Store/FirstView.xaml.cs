using Cirrious.MvvmCross.WindowsCommon.Views;
using PrePopulatedDatabase.Core.Entities;
using PrePopulatedDatabase.Core.ViewModels;
using PrePopulatedDatabase.Store.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace PrePopulatedDatabase.Store.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class FirstView : MvxWindowsPage
    {


        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }


        public FirstView()
        {
            this.InitializeComponent();


        }



        private void ItemListView_OnItemClick(object sender, ItemClickEventArgs e)
        {


            ((FirstViewModel) ViewModel).SelectedBowTie = (BowTie) e.ClickedItem;


        }
    }
}