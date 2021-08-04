using Xamarin.Forms;
using ListView.Views;

namespace ListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ToursPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
