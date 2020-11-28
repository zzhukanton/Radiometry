using System;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class Success : ContentPage
	{
		public Success()
		{
			InitializeComponent();
		}

		private async void ResultsButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Tablet());
		}

		private async void HomeButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Home());
		}
	}
}
