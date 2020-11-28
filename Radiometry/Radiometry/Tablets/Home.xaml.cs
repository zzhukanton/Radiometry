using System;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class Home : ContentPage
	{
		public Home()
		{
			InitializeComponent();

			this.NewTabletButton.Clicked += NewTabletButton_Clicked;
		}

		private async void NewTabletButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Measurement());
		}

		private async void ExitButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MainPage());
		}

		private async void OpenTabletButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Tablet());
		}
	}
}
