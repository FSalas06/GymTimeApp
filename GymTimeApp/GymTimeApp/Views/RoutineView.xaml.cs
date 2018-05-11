using GymTimeApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymTimeApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoutineView : ContentPage
    {
		RoutineViewModel _viewModel;

		public RoutineView()
		{
			InitializeComponent();         
			BindingContext = _viewModel = new RoutineViewModel();
		}
    }
}
