using System;
using Xamarin.Forms;

namespace XamarinBank
{
    public partial class MainPage : ContentPage
    {
        private readonly TapGestureRecognizer _registerLabelTap = new TapGestureRecognizer();
        public MainPage()
        {
            InitializeComponent();
            _registerLabelTap.Tapped += RegisterLabelOnTapped;
            RegisterLabel.GestureRecognizers.Add(_registerLabelTap);
        }

        private async void RegisterLabelOnTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.RegistrationPage());
        }
    }
}
