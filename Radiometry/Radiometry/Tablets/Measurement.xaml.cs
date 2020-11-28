using System;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class Measurement : ContentPage
	{
		public Measurement()
		{
			InitializeComponent();
		}

		private async void Finish_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Success());
		}
	}
}
