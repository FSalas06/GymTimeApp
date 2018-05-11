using System;
using System.Collections.Generic;
using GymTimeApp.ViewModels.Login;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymTimeApp.Views.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
		private readonly LoginViewModel _viewModel;

        public LoginView()
        {
            InitializeComponent();
			BindingContext = _viewModel = new LoginViewModel();
        }


    }
}
