using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Username:Ali Password:Ali 

            if (username.Text == "111" && password.Text == "111")
            {
                await Navigation.PushAsync(new MainPage());
               
            }
            else
            {
                await DisplayAlert("خطأ!", "يوجد خطأ في معلومات الدخول", "حسنًا");
            }

           
        }
        private async void InfoButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }
    }
}