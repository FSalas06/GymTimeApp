using System;
using System.IO;
using GymTimeApp.Interfaces;
using GymTimeApp.iOS.DependencyServices;

[assembly: Xamarin.Forms.Dependency(typeof(DataBaseIOS))]
namespace GymTimeApp.iOS.DependencyServices
{
	public class DataBaseIOS : IDataBase
    {
		public string GetDatabasePath()
		{
			return Path.Combine(
				Environment.GetFolderPath(
					Environment.SpecialFolder.MyDocuments),
				"..","Library", Constants.NameDataBase);
		}
	}
}
