using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinBank.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IdCardPage : ContentPage
    {
        public IdCardPage()
        {
            InitializeComponent();
        }

        private async void GoBackButtonOnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }

        private async void NextStepButtonOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.LocationPage());
        }
    }
}