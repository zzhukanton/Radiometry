using System;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class Login : ContentPage
	{
		public Login()
		{
			InitializeComponent();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}
