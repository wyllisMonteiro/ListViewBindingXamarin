using ListView.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToursPage : ContentPage
    {
        public ToursPage()
        {
            InitializeComponent();

            BindingContext = new ToursPageViewModel();
        }
    }
}