using System;
using GymTimeApp.LocalData;
using GymTimeApp.Views;
using GymTimeApp.Views.Login;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GymTimeApp
{
    public partial class App : Application
    {
		static DataBase db;

        public App()
        {
            InitializeComponent();

			MainPage = new Dashboard();
        }

		public static DataBase DB
        {
            get
            {
                if (db == null)
                {
					db = new DataBase(Constants.NameDataBase);
                }
                return db;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
