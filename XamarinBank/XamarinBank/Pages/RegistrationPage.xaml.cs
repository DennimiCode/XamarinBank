using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinBank.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void GoBackButtonOnClick(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }

        private async void NextStepButtonOnClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.IdCardPage());
        }
    }
}