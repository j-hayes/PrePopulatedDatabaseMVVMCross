﻿

#pragma checksum "C:\Users\jhayes\Documents\Visual Studio 2013\Projects\PrePopulatedDatabase.Core\PrePopulatedDatabase.Store\FirstView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DE0E585E0C218303A94149799CE0D7AD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrePopulatedDatabase.Store.Views
{
    partial class FirstView : global::Cirrious.MvvmCross.WindowsCommon.Views.MvxWindowsPage
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Cirrious.MvvmCross.WindowsCommon.Views.MvxWindowsPage pageRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Data.CollectionViewSource itemsViewSource; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView ItemListView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button backButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock pageTitle; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///FirstView.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (global::Cirrious.MvvmCross.WindowsCommon.Views.MvxWindowsPage)this.FindName("pageRoot");
            itemsViewSource = (global::Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("itemsViewSource");
            ItemListView = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("ItemListView");
            backButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
            pageTitle = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("pageTitle");
        }
    }
}


