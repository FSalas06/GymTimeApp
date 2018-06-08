using GymTimeApp.ViewModels.Routines;
using Xamarin.Forms;

namespace GymTimeApp.Views.Routines
{
    public partial class RoutineView : ContentPage
    {
        #region private properties
        RoutineViewModel _viewModel;
        #endregion

        #region public methods
        /// <summary>
        /// Initializes a new instance of the <see cref="T:GymTimeApp.Views.RoutineView"/> class.
        /// </summary>
        public RoutineView()
        {
            InitializeComponent();
            BindingContext = _viewModel = new RoutineViewModel();
        }
        #endregion

        #region protected Methods
        /// <summary>
        /// Ons the appearing.
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel?.OnAppearing();
        }
        #endregion
    }
}
