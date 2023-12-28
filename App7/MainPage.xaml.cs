using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App7
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

           
        }

        private async void EnglishSectionButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnglishSection());
        }

        private async void MathSectionButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MathSection());
        }

    }
}
