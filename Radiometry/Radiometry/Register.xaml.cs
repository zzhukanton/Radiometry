using System;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class Register : ContentPage
	{
		public Register()
		{
			InitializeComponent();

			this.BackButton.Clicked += Back_Clicked;
			this.CreateButton.Clicked += Create_Clicked;
		}

		private async void Back_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		private async void Create_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Home());
		}
	}
}
