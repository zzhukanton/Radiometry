using System;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class Login : ContentPage
	{
		public Login()
		{
			InitializeComponent();

			this.BackButton.Clicked += Back_Clicked;
			this.EnterButton.Clicked += Enter_Clicked;
		}

		private async void Back_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		private async void Enter_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Home());
		}
	}
}
