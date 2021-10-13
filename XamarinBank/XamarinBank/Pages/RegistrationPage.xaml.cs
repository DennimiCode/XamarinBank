using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

        private void GoBackButtonOnClick(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void NextStepButtonOnClick(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Pages.IdCardPage();
        }
    }
}