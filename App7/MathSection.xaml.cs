using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MathSection : ContentPage
	{
        public MathSection()
        {
            InitializeComponent();
          

        }

        private async void AdditionExamButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdditionExamPage());
        }
        private async void SubtractionExamButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubtractionExamPage());
        }
        private async void MultiplicationExamButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MultiplicationExamPage());
        }
        private async void DivisionExamButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DivisionExamPage());
        }
    }
}