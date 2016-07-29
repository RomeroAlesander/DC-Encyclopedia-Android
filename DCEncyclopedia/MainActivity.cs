using Android.App;
using Android.Widget;
using Android.OS;
using Android.Database;
using Android.Database.Sqlite;
using SQLite;
using SQLitePCL;
using System.Collections.Generic;
using Android.Content;
using System;
using System.Drawing;

namespace DCEncyclopedia
{
	//Create the main menu for the App
	[Activity (Label = "DC Encyclopedia", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		ListView MyList;
		SuperheroesDatabase vdb;
		ICursor cursor;
		string selected;

	

		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Call the SplashScreen
			base.OnCreate (savedInstanceState);
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Splash);
			ImageView splash = FindViewById<ImageView> (Resource.Id.splash);
			splash.SetImageResource (Resource.Drawable.splashlogo);
			splash.Click += delegate {
				//Call the main menu when the splashscreen is clicked
				StartActivity(typeof(Menu));
			};

		}

		[Activity (Label = "Superheroes")]			
		public class Superheroes 
		{
			[PrimaryKey, AutoIncrement]
			public int ID { get; set; }
			public string Name { get; set; }
			public string Description { get; set; }

//			public override string ToString()
//			{
//				return string.Format("[Superheroes: ID={0}, Name={1}, Description{2}]", ID, Name, Description);
//			}
		}



	}
}


