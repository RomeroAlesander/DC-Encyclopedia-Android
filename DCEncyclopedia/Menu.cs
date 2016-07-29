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
	[Activity (Label = "Menu")]			
	public class Menu : Activity
	{

		ListView MyList;
		SuperheroesDatabase vdb;
		ICursor cursor;
		string selected;


		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Create the menu layout items
			base.OnCreate (savedInstanceState);
			vdb = new SuperheroesDatabase(this);
			// Set our view from the "main" layout resource
			//SetContentView (Resource.Layout.Main);
			SetContentView(Resource.Layout.Menu);
			ImageView DC = FindViewById<ImageView> (Resource.Id.Logo);
			DC.SetImageResource (Resource.Drawable.splat);

			Button characters = FindViewById<Button> (Resource.Id.btnChar);
			Button addNew = FindViewById<Button> (Resource.Id.btnAdd);
			Button about = FindViewById<Button> (Resource.Id.btnAbout);

			//Call the different activities when the buttons are clicked
			about.Click += delegate {
				StartActivity(typeof(About));
			};

			characters.Click += delegate {
				StartActivity(typeof(Characters));
			};

			addNew.Click += delegate {
				StartActivity(typeof(AddNew));
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

