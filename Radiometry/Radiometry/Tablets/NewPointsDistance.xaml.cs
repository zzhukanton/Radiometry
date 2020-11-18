using System;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class NewPointsDistance : ContentPage
	{
		public NewPointsDistance()
		{
			InitializeComponent();
		}

		private async void BackButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		private async void StartButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Measurement());
		}
	}
}
