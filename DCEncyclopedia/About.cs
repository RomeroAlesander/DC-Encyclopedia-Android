
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

namespace DCEncyclopedia
{
	[Activity (Label = "About")]			
	public class About : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView(Resource.Layout.About);

			Button sendEmail = FindViewById<Button> (Resource.Id.btnEmail);

			sendEmail.Click += delegate {
				Intent intent = new Intent(Intent.ActionSend);
				intent.SetType("plain/text");
				intent.PutExtra(Intent.ExtraEmail, new String[] { "alesander11@gmail.com" });
				StartActivity(Intent.CreateChooser(intent, ""));
			};
		}
	}
}

