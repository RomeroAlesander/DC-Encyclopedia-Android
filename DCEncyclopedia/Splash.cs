
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;

namespace DCEncyclopedia
{
	[Activity (Label = "Splash")]			
	public class Splash : Activity
	{
		//Show the splashscreen
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Splash);
			ImageView splash = FindViewById<ImageView> (Resource.Id.splash);
			splash.SetImageResource (Resource.Drawable.splashlogo);

		
		
		

		}



	}


}

