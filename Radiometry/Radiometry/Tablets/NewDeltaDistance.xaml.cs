using System;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class NewDeltaDistance : ContentPage
	{
		public NewDeltaDistance()
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
