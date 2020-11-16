using System;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class Isolines : ContentPage
	{
		public Isolines()
		{
			InitializeComponent();

			this.BackButton.Clicked += BackButton_Clicked;
		}

		private async void BackButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}
