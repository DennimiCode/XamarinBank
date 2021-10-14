using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinBank.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationPage : ContentPage
    {
        public LocationPage()
        {
            InitializeComponent();
        }

        private async void GoBackButtonOnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }

        private void NextStepButtonOnClicked(object sender, EventArgs e)
        {
            
        }

        private void LocationCheckBoxOnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (LocationCheckBox.IsChecked)
                ResidentialAddressEntry.IsEnabled = false;
            else
                ResidentialAddressEntry.IsEnabled = true;
        }
    }
}