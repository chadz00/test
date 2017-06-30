using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;


namespace App1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new App1.MainPage();
		}

		protected override void OnStart ()
		{
          //  MobileCenter.Start("uwp=263d95e1-b417-4d88-a715-a1389cba2aa3;" +
            //                   "android={1310dbc6-7737-4e2d-bfdb-4c823d2726ea}" +
              //                 "ios={f9869dc6-2bfe-4c58-8c42-4f7cae2df611}",
                //               typeof(Analytics));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
