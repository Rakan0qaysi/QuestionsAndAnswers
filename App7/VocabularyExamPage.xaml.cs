using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VocabularyExamPage : ContentPage
	{
        int TotalScore;
        Exam Total = new Exam();
       
    
        public VocabularyExamPage ()
		{
			InitializeComponent ();
		}

        private void Question_Answer(object sender, CheckedChangedEventArgs e)
        {
            TotalScore = TotalScore + 10;
        }
   
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var choice = await DisplayAlert("ALERT", "Are You Sure You Want Submit Your Answers?", "Yes", "No");

            if (choice) {
            var String = await DisplayAlert("Your Score is:", Convert.ToString(TotalScore), "Go home" ,"Exam Page") ;
                
                if (String) {
                    await Navigation.PushAsync(new MainPage());
                            }
                        else { 
                     await Navigation.PushAsync(new EnglishSection());
                             }
               
            }
        }
        
       
    }
}