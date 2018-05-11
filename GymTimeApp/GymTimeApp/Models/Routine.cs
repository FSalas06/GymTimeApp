using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace GymTimeApp.Models
{
	public class Routine
    {      
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public int Id
		{
			get;
			set;
		}

        public int GymDay
		{
			get;
			set;
		}

        public int Sections
		{
			get;
			set;
		}

		public string NameExercise
		{
			get;
			set;
		}

		public string Type
		{
			get;
			set;
		}

		public string UrlVideo
		{
			get;
			set;
		}

        public int CustomSeries
		{
			get;
			set;
		}

        public int CustomRepeats
		{
			get;
			set;
		}

		public int? CustomWeight
        {
            get;
            set;
        }

		[JsonIgnore]
        public string Description
		{
			get
			{
				string customweight = string.IsNullOrEmpty(CustomWeight.ToString()) ? string.Empty : $"Peso:" + CustomWeight + "Kg";
				return $"{CustomSeries} Series | {CustomRepeats} Repeticiones \n" +customweight;
			}
		}
	}
}
