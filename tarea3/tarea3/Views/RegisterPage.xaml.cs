using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea3.ModelsViews;

using Xamarin.Forms;

namespace tarea3.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Password1.Text) || string.IsNullOrEmpty(Password2.Text) || string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Name.Text))
            {
                await DisplayAlert("Register Failed", "Please fill all fields", "Ok");
            }
            else if (Password1.Text != Password2.Text)
            {
                await DisplayAlert("Wrog Password", "Confirm your password", "Ok");
            }
            else
            {
                await DisplayAlert("successfully", "Register succesfull", "Ok");
            }

        }
    }
}
