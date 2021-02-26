using tarea3.Models;
using tarea3.ModelsViews;

using Xamarin.Forms;

namespace tarea3.Views
{
    public partial class HomeMenuPage : ContentPage
    {
        public HomeMenuPage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();

        }
    }
}
