using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Radiometry
{
	public partial class MainPage : ContentPage
	{
		public List<WelcomeItem> WelcomeItems { get; set; }

		public MainPage()
		{
			InitializeComponent();

			this.WelcomeItems = new List<WelcomeItem>
			{
				new WelcomeItem { ImageUrl = "logo.png", Message = "Начните работу прямо сейчас." },
				new WelcomeItem { ImageUrl = "logo.png", Message = "Используйте возможности мобильных устройств." },
				new WelcomeItem { ImageUrl = "logo.png", Message = "Узнать больше о радиометрии." }
			};
			this.BindingContext = this;

			this.LoginButton.Clicked += Login_Clicked;
			this.RegisterButton.Clicked += Register_Clicked;
		}

		private async void Login_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Login());
		}

		private async void Register_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Register());
		}
	}

	public class WelcomeItem 
	{
		public string ImageUrl { get; set; }

		public string Message { get; set; }
	}

}
