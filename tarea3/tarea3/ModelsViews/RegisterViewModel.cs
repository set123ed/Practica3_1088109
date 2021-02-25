using System;
using System.Windows.Input;
using tarea3.Views;
using Xamarin.Forms;
namespace tarea3.ModelsViews
{
    public class RegisterViewModel
    {
        //SignUp
        public string NameEntry { get; set; }
        public string EmailEntry { get; set; }
        public string PasswordEntry { get; set; }
        public string PasswordConfirmEntry { get; set; }
        public ICommand SignUpCommand { get; }
        public RegisterViewModel()
        {
            SignUpCommand = new Command(OnSignUpCommand);
        }
        private async void OnSignUpCommand()
        {
            if (string.IsNullOrEmpty(NameEntry)||string.IsNullOrEmpty(EmailEntry)||string.IsNullOrEmpty(PasswordEntry)||string.IsNullOrEmpty(PasswordConfirmEntry))
            {
                await App.Current.MainPage.DisplayAlert("Register Failed", "Please fill all fields", "Ok");
            }
            else if (PasswordEntry != PasswordConfirmEntry)
            {
                await App.Current.MainPage.DisplayAlert("Wrog Password", "Confirm your password", "Ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("successfully", "Register succesfull", "Ok");
            }
        }
    }
}
