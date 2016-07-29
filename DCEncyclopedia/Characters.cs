
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
	[Activity (Label = "Characters")]			
	public class Characters : Activity
	{
		ListView MyList;
		SuperheroesDatabase vdb;
		ICursor cursor;
		string selected;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

			MyList = FindViewById<ListView> (Resource.Id.myListView);

			// create the cursor
			vdb = new SuperheroesDatabase(this);
			cursor = vdb.ReadableDatabase.RawQuery("SELECT * FROM Superheroes", null);
			StartManagingCursor(cursor);


			// which columns map to which layout controls
			string[] fromColumns = new string[] { "name" };
			int[] toControlIds = new int [] {Android.Resource.Id.Text1};

			// use a SimpleCursorAdapter
			MyList.Adapter = new SimpleCursorAdapter(this, Android.Resource.Layout.SimpleListItem1, cursor, fromColumns, toControlIds);


			//			if (MyList.SelectedItem.ToString () != null) {
			//				selected = MyList.SelectedItem.ToString ();
			//			}

			MyList.ItemClick += OnListItemClick;
		}

		//When an item of the list is clicked, it reaches to the SQLite database and retrieves the information associated
		protected void OnListItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
		{

			selected = cursor.GetString (1);
			Toast.MakeText (this, selected, ToastLength.Short).Show();
			//			var obj = MyList.Adapter.GetItem(e.Position);
			//			var text = obj.ToString ();
			//			//var curs = (ICursor)obj;
			//			//var text = curs.GetString(1); // 'name' is column 1
			//			Android.Widget.Toast.MakeText(this, text, Android.Widget.ToastLength.Short).Show();
			//			System.Console.WriteLine("Clicked on " + text);
			SetContentView (Resource.Layout.Character);


			TextView name = FindViewById<TextView> (Resource.Id.Name);
			TextView description = FindViewById<TextView> (Resource.Id.Description);
			ImageView picture = FindViewById<ImageView> (Resource.Id.Picture);

			//SQL commands to retrieve information regarding the clicked item from the list
			cursor = vdb.ReadableDatabase.RawQuery("SELECT name FROM superheroes WHERE name = '" + selected + "'", null);
			cursor.MoveToFirst (); //Edited based on suggestion from SAM
			string strName = cursor.GetString(cursor.GetColumnIndex("name"));
			name.Text = strName;
			cursor = vdb.ReadableDatabase.RawQuery("SELECT description FROM superheroes WHERE name = '" + selected + "'", null);
			cursor.MoveToFirst (); //Edited based on suggestion from SAM
			strName = cursor.GetString(cursor.GetColumnIndex("description"));
			description.Text = strName;

			//Cleaning the selected string to get the matching image for the selected character
			selected = selected.Replace (" ", "");
			selected = selected.Replace ("-", "");
			String uri = "drawable/" + selected;
			//Toast.MakeText (this, uri, ToastLength.Short).Show();
			int imageResource = 0;
			imageResource= (int)typeof(Resource.Drawable).GetField(selected).GetValue(null);
			//int imageResource = Resources.GetIdentifier (uri, null, PackageName);
			//Toast.MakeText (this, imageResource.ToString(), ToastLength.Short).Show();
			Android.Graphics.Drawables.Drawable res = Resources.GetDrawable (imageResource);
			//int drawableID = Resources.GetInteger(Resources.GetIdentifier(selected, "drawable", PackageName));
			picture.SetImageDrawable (res);

			//Clicking the picture will go back to the main menu
			picture.Click += delegate {
				// Set our view from the "main" layout resource
				SetContentView (Resource.Layout.Main);

				MyList = FindViewById<ListView> (Resource.Id.myListView);


				// create the cursor
				vdb = new SuperheroesDatabase (this);
				cursor = vdb.ReadableDatabase.RawQuery ("SELECT * FROM Superheroes", null);
				StartManagingCursor (cursor);


				// which columns map to which layout controls
				string[] fromColumns = new string[] { "name" };
				int[] toControlIds = new int [] { Android.Resource.Id.Text1 };

				// use a SimpleCursorAdapter
				MyList.Adapter = new SimpleCursorAdapter (this, Android.Resource.Layout.SimpleListItem1, cursor, fromColumns, toControlIds);


				MyList.ItemClick += OnListItemClick;

			};

			ImageButton Menu;
			Menu = FindViewById<ImageButton> (Resource.Id.imageButton1);
			Menu.Click += delegate {
				// Set our view from the "main" layout resource
				SetContentView (Resource.Layout.Main);

				MyList = FindViewById<ListView> (Resource.Id.myListView);

				// create the cursor
				vdb = new SuperheroesDatabase (this);
				cursor = vdb.ReadableDatabase.RawQuery ("SELECT * FROM Superheroes", null);
				StartManagingCursor (cursor);


				// which columns map to which layout controls
				string[] fromColumns = new string[] { "name" };
				int[] toControlIds = new int [] { Android.Resource.Id.Text1 };

				// use a SimpleCursorAdapter
				MyList.Adapter = new SimpleCursorAdapter (this, Android.Resource.Layout.SimpleListItem1, cursor, fromColumns, toControlIds);


				MyList.ItemClick += OnListItemClick;

			};

			Button Back;
			Back = FindViewById<Button> (Resource.Id.btnMenu);
			Back.Click += delegate {
				// Set our view from the "main" layout resource
				SetContentView (Resource.Layout.Main);

				MyList = FindViewById<ListView> (Resource.Id.myListView);


				// create the cursor
				vdb = new SuperheroesDatabase(this);
				cursor = vdb.ReadableDatabase.RawQuery("SELECT * FROM Superheroes", null);
				StartManagingCursor(cursor);


				// which columns map to which layout controls
				string[] fromColumns = new string[] { "name" };
				int[] toControlIds = new int [] {Android.Resource.Id.Text1};

				// use a SimpleCursorAdapter
				MyList.Adapter = new SimpleCursorAdapter(this, Android.Resource.Layout.SimpleListItem1, cursor, fromColumns, toControlIds);


				MyList.ItemClick += OnListItemClick;


			};
		}
	}
}

