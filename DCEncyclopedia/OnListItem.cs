
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
	[Activity (Label = "OnListItem")]			
	public class OnListItem : Activity
	{
		ListView MyList;
		SuperheroesDatabase vdb;
		ICursor cursor;
		string selected;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);


		}

	}
}

