using System;
using System.Windows.Input;
using GymTimeApp.Views;
using Xamarin.Forms;

namespace GymTimeApp.ViewModels.Login
{
	public class LoginViewModel : BaseViewModel
    {
		#region private properties
		string _username;
		string _password;
		#endregion

		#region public properties
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				SetObservableProperty(ref _username, value);
			}
		}

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
		public string Password
        {
			get
            {
				return _password;
            }
            set
            {
				SetObservableProperty(ref _password, value);
            }
        }

        /// <summary>
        /// Gets the login command.
        /// </summary>
        /// <value>The login command.</value>
		public ICommand LoginCommand
		{
			private set;
			get;
		}
		#endregion

		#region public methods
        /// <summary>
        /// Initializes a new instance of the <see cref="T:GymTimeApp.ViewModels.Login.LoginViewModel"/> class.
        /// </summary>
        public LoginViewModel()
		{
			LoginCommand = new Command(ValidateLogin);
		}
		#endregion

		#region private Methods
        /// <summary>
        /// Validates the login.
        /// </summary>
        /// <param name="obj">Object.</param>
		private void ValidateLogin(object obj)
        {
			Application.Current.MainPage = new Dashboard();
        }
		#endregion

		#region protected Methods
		#endregion


	}
}
