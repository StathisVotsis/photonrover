using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Particle;

namespace photonrover
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            //var pass1 = usern.Text;
            //var pass1 = MainPage.userna
           var pass1 = username.Text;
           var pass2 = password.Text;
           username.Text = "";
           password.Text = "";
           LoginCloud(pass1, pass2);
        }

        async void LoginCloud(string st1, string st2)
        {
            var loginSuccess = await ParticleCloud.SharedInstance.LoginWithUserAsync(st1, st2);
            if (loginSuccess)
            {
                await DisplayAlert("You are loggedin as", st1, "OK");
                NewPage(st1, st2);

            }
            else
            {
                await DisplayAlert("Invalid user credentials: ", st1, "OK");
            }

        }

        private void NewPage(string st3, string st4)
        {
            Application.Current.MainPage = new SecondPage();
            //Application.Current.MainPage = new ListViewPage1();
        }
    }
}
