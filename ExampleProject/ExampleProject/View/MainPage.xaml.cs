using ExampleProject.ViewModel;
using Xamarin.Forms;

namespace ExampleProject
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel mainPageViewModel;

        public MainPage()
        {
            InitializeComponent();

            mainPageViewModel = new MainPageViewModel();
            BindingContext = mainPageViewModel;
        }
    }
}
