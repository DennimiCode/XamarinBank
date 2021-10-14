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
    public partial class IdCardPage : ContentPage
    {
        public IdCardPage()
        {
            InitializeComponent();
        }

        private void GoBackButtonOnClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }

        private void NextStepButtonOnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.LocationPage());
        }
    }
}