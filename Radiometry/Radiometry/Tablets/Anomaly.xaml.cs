using System;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class Anomaly : ContentPage
	{
		public Anomaly()
		{
			InitializeComponent();
		}

		private async void BackButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}
