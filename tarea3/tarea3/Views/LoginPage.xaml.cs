using System;
using System.Collections.Generic;
using tarea3.ModelsViews;

using Xamarin.Forms;

namespace tarea3.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
        async void RegisterButton(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());

        }

        async void LogginButton(System.Object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Password.Text))
            {
                await DisplayAlert("Login Failed", "Please fill all fields", "ok");
            }
            else
            {
                await DisplayAlert("Welcome", Email.Text, "ok");

            }
        }

    }
}
