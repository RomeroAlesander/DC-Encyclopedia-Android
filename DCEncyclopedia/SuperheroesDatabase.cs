
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
using Android.Database.Sqlite;

//Create the database and insert some characters and descriptions
namespace DCEncyclopedia
{
	class SuperheroesDatabase  : SQLiteOpenHelper {
		public static readonly string create_table_sql =
			"CREATE TABLE [superheroes] ([_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, [name] TEXT NOT NULL UNIQUE, [description] NOT NULL UNIQUE)";
		public static readonly string DatabaseName = "superheroes.db";
		public static readonly int DatabaseVersion = 1;
		public SuperheroesDatabase(Context context) : base(context, DatabaseName, null, DatabaseVersion) { }
		public override void OnCreate(SQLiteDatabase db)
		{
			db.ExecSQL(create_table_sql);
			// seed with data
			db.ExecSQL("INSERT INTO Superheroes (name, description) VALUES ('Adam Strange', 'Adam Strange is the human champion of the alien planet Rann, an archaeologist who fights monsters using a jet pack and ray gun')");
			db.ExecSQL("INSERT INTO Superheroes (name, description) VALUES ('Alfred Pennyworth', 'Alfred Pennyworth is the British butler and valet to the Wayne Family. He took up the role of legal guardian of Bruce Wayne after the murder of Thomas and Martha Wayne')");
			db.ExecSQL("INSERT INTO Superheroes (name, description) VALUES ('Amanda Waller', 'Amanda The Wall Waller is a hardline top-ranking U.S. Government agent involved in clandestine operations')");
			db.ExecSQL("INSERT INTO Superheroes (name, description) VALUES ('Amazo', 'Amazo is a robotic enemy of the Justice League of America, a deadly android designed by the mad scientist Professor Ivo')");
			db.ExecSQL("INSERT INTO Superheroes (name, description) VALUES ('Bane', 'Bane is a brilliant world-class fighter and tactical genius who augments his great physical strength with a steroid called venom')");
			db.ExecSQL("INSERT INTO Superheroes (name, description) VALUES ('Batman', 'Batman is the super-hero protector of Gotham City, a man dressed like a bat who fights against evil and strikes terror into the hearts of criminals everywhere')");
			db.ExecSQL("INSERT INTO Superheroes (name, description) VALUES ('Superman', 'Superman, also known as the Man of Steel, is one of the most powerful superheroes in the DC Universe. His abilities include incredible super-strength, super-speed, invulnerability, freezing breath, flight, and heat-vision')");
			db.ExecSQL("INSERT INTO Superheroes (name, description) VALUES ('Animal Man', 'Animal Man is a super-hero who can use the abilities of any animal. His powers are gained from tapping into the morphogenic field known as The Red, giving him the power of any animal on the planet and sometimes the universe')");
			db.ExecSQL("INSERT INTO Superheroes (name, description) VALUES ('Anti-Monitor', 'The Anti-Monitor is a supremely powerful being who controls the Antimatter Universe, acting as an evil counterpart to his brother the Monitor')");
			db.ExecSQL("INSERT INTO Superheroes (name, description) VALUES ('Aqualad', 'Aqualad, also known as Garth is Aquamans teenage sidekick. As an adult he took the name Tempest. He is a member of the Aquaman Family along with other side-kicks including Aquagirl and Dolphin')");
			//db.ExecSQL("INSERT INTO Superheroes (name, description) VALUES ('', '')");
			}

		public override void OnUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
		{   // not 
			throw new NotImplementedException();
		}
	}
}

