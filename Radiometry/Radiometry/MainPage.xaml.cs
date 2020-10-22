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
				new WelcomeItem { ImageUrl = "first.jpg", Message = "Начните работу прямо сейчас." },
				new WelcomeItem { ImageUrl = "first.jpg", Message = "Используйте возможности мобильных устройств." },
				new WelcomeItem { ImageUrl = "first.jpg", Message = "Узнать больше о радиометрии." }
			};
			this.BindingContext = this;
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
