﻿
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

using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;

namespace DCEncyclopedia
{
	[Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]		
	public class SplashActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			var intent = new Intent(this, typeof(MainActivity));
			StartActivity(intent);
			Finish();
		}


	}
}

