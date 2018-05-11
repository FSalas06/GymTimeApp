using System;
using Xamarin.Forms;

namespace GymTimeApp.Common
{
	public class CardView : Frame
	{
        public CardView()
        {
			HasShadow = true;
			CornerRadius = 6;
			BackgroundColor = Color.Transparent;
			BorderColor = Color.Yellow;
        }
    }
}
