using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinBank
{
    public partial class MainPage : ContentPage
    {
        private TapGestureRecognizer _registerLabelTap = new TapGestureRecognizer();
        public MainPage()
        {
            InitializeComponent();
            _registerLabelTap.Tapped += (sender, args) =>
            {
                Application.Current.MainPage = new Pages.RegistrationPage();
            };
            RegisterLabel.GestureRecognizers.Add(_registerLabelTap);
        }
    }
}
