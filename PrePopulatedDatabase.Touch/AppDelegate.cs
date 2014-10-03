using System;
using System.IO;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.ViewModels;

namespace PrePopulatedDatabase.Touch
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate
    {
        UIWindow _window;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            _window = new UIWindow(UIScreen.MainScreen.Bounds);

            var setup = new Setup(this, _window);
            setup.Initialize();

            var startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();

            _window.MakeKeyAndVisible();


            /*Code To populate your Databsae*/

            string dbname = "BowTiesDb.sqlite";
            string dbAssetLocation = "Assets/" + dbname;

            string pathToDeployed = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), dbname);//This is the path to your Deployed Databse
			string assetDatabasePath = Path.Combine(NSBundle.MainBundle.BundlePath, dbAssetLocation); //This is the Path to your Resource Files availible to your apps

			File.Delete (pathToDeployed);
			if (File.Exists (assetDatabasePath)) {
				Console.WriteLine ("Asset Database Content Does exist at path");
				if (!File.Exists (pathToDeployed)) {
					Console.WriteLine ("DB file Didn't Exist on app");
					File.Copy (assetDatabasePath, pathToDeployed);
				}
				else {
					Console.WriteLine ("DB file Did Exist");
				}
			} else 
			
			{
				Console.WriteLine ("Db file does not exist in assets");
			}


            return true;
        }
    }
}