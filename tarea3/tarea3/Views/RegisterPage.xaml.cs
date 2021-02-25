using tarea3.ModelsViews;

using Xamarin.Forms;

namespace tarea3.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();

        }

        //async void Button_Clicked(System.Object sender, System.EventArgs e)
       

    }
}

