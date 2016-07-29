
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
	[Activity (Label = "AddNew")]			
	public class AddNew : Activity
	{
		ListView MyList;
		SuperheroesDatabase vdb;
		ICursor cursor;
		string selected;

		//This activity will be used to add new characters to the list (IS DISABLED NOW)
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Add);

			EditText name = FindViewById<EditText>(Resource.Id.txtName);
			EditText description = FindViewById<EditText>(Resource.Id.txtDescription);
			Button save = FindViewById<Button>(Resource.Id.btnSave);
			save.Click += delegate {
				if(name.Text == null || description.Text == "")
					Toast.MakeText (this, "Please enter some information", ToastLength.Short).Show();
				else
					vdb = new SuperheroesDatabase(this);
				vdb.WritableDatabase.RawQuery("Insert into superheroes (name, description) VALUES ('" + name.Text + "','" + description.Text + "')",null);
			};
		}
	}
}

