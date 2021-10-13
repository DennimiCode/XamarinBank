using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void GoBackButtonOnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new IdCardPage();
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