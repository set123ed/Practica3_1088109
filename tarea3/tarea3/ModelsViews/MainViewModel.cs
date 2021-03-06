﻿using System;
using System.Windows.Input;
using tarea3.Views;
using Xamarin.Forms;
namespace tarea3.ModelsViews
{
    public class MainViewModel
    {
        //Login
        public string EmailEntry { get; set; }
        public string PasswordEntry { get; set; }
        public ICommand LogginCommand { get; }
        public ICommand SignUpCommand { get; }
        public MainViewModel()
        {
            LogginCommand = new Command(OnLogin);
            SignUpCommand = new Command(OnSignUp);
        }
        private async void OnLogin()
        {
                if(string.IsNullOrEmpty(EmailEntry)||string.IsNullOrEmpty(PasswordEntry))
            {
                await App.Current.MainPage.DisplayAlert("Login Failed", "Please fill all fields", "ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Welcome", EmailEntry, "ok");
                await Application.Current.MainPage.Navigation.PushAsync(new HomeTabbedPage());
            }
        }
        private async void OnSignUp()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }
    }
}
