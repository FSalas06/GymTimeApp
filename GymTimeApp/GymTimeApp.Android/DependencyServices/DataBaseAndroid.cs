using System;
using System.IO;
using GymTimeApp.Droid.DependencyServices;
using GymTimeApp.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(DataBaseAndroid))]
namespace GymTimeApp.Droid.DependencyServices
{
	public class DataBaseAndroid : IDataBase
    {
		public string GetDatabasePath()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			return Path.Combine(path, Constants.NameDataBase);
		}
	}
}
