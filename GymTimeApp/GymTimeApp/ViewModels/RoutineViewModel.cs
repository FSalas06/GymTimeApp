using System;
using System.Collections.ObjectModel;
using GymTimeApp.Models;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using GymTimeApp.LocalData;
using GymTimeApp.Views;

namespace GymTimeApp.ViewModels
{
	public class RoutineViewModel : BaseViewModel
	{        	     
		int _stepSection;
		int _numStep;
		ObservableCollection<Routine> _routineList;
  
		public int StepSection
		{
			get
			{
				return _stepSection;
			}
			set
			{
				SetObservableProperty(ref _stepSection, value);
			}
		}      
        
		public int NumStep
		{
			get
            {
				return _numStep;
            }
            set
            {
				SetObservableProperty(ref _numStep, value);            
				RoutineList = new ObservableCollection<Routine>(BackRoutineList.Where(r => r.Sections == _numStep));            
            }
		}

		public ObservableCollection<Routine> RoutineList
		{
			get
            {
				return _routineList;
            }
            set
            {
				SetObservableProperty(ref _routineList, value);
            }
		}

		public ObservableCollection<Routine> BackRoutineList
        {
            get;
            set;
        }

		public ICommand EditValueRoutineCommand
        {
            get;
            private set;
        }

		public RoutineViewModel()
		{
			RoutineList = new ObservableCollection<Routine>();
			BackRoutineList = new ObservableCollection<Routine>(FillRoutine());         
			EditValueRoutineCommand = new Command<Routine>(EditValueRoutine);
			GetSections();

		}

		private async void EditValueRoutine(Routine obj)
		{
			await Navigation.PushAsync(new EditRoutineView());
		}

		private ObservableCollection<Routine> FillRoutine()
		{
			#region sample routine List
			var r = new ObservableCollection<Routine>
			{
				new Routine
				{
					Id = 0,
					Sections = 1,
					NameExercise = "Excercise Name 1",
					Type = "Fuerza",
					UrlVideo = "Sample",
					CustomSeries = 3,
					CustomRepeats = 15,
					CustomWeight = null
				},

				new Routine
				{
					Id = 1,
					Sections = 1,
					NameExercise = "Excercise Name 2",
					Type = "Fuerza",
					UrlVideo = "Sample",
					CustomSeries = 3,
					CustomRepeats = 15,
					CustomWeight = null,
				},

				new Routine
				{
					Id = 2,
					Sections = 2,
					NameExercise = "Excercise Name 3",
					Type = "Fuerza",
					UrlVideo = "Sample",
					CustomSeries = 3,
					CustomRepeats = 15,
					CustomWeight = 10,
				},

				new Routine
				{
					Id = 3,
					Sections = 2,
					NameExercise = "Excercise Name 4",
					Type = "Fuerza",
					UrlVideo = "Sample",
					CustomSeries = 3,
					CustomRepeats = 15,
					CustomWeight = 10,
				},

				new Routine
				{
					Id = 4,
					Sections = 3,
					NameExercise = "Excercise Name 5",
					Type = "Fuerza",
					UrlVideo = "Sample",
					CustomSeries = 3,
					CustomRepeats = 15,
					CustomWeight = 10,
				},

				new Routine
				{
					Id = 4,
					Sections = 3,
					NameExercise = "Excercise Name 6",
					Type = "Fuerza",
					UrlVideo = "Sample",
					CustomSeries = 3,
					CustomRepeats = 15,
					CustomWeight = 10,
				}
			};

			return r;
			#endregion
		}

		private void GetSections()
		{
			StepSection = BackRoutineList.OrderByDescending(r => r.Sections).FirstOrDefault().Sections;
			NumStep = 1;
		}

        
	}
}
