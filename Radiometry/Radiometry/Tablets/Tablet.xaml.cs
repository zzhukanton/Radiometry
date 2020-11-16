using System;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class Tablet : ContentPage
	{
		public Tablet()
		{
			InitializeComponent();

			this.IsolinesButton.Clicked += Isolines_Clicked;
			this.ProfilesButton.Clicked += ProfilesButton_Clicked;
			this.AnomalyButton.Clicked += AnomalyButton_Clicked;
		}

		private async void Isolines_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Isolines());
		}

		private async void ProfilesButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Profiles());
		}

		private async void AnomalyButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Anomaly());
		}
	}
}
