using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace App7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EnglishSection : ContentPage
	{
        public EnglishSection()
        {
            InitializeComponent();
        }

        private async void VocabularyExamButton(object sender, EventArgs e)
        {
                await Navigation.PushAsync(new VocabularyExamPage());  
            
        }

        private async void GrammerExamButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GrammerExamPage());
        }


    }
}