using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListView.ViewModels
{
    class TourContentViewModel
    {
        public string Text { get; private set; }
        public ICommand GoToNext { get; private set; }


        public TourContentViewModel()
        {
            GoToNext = new Command(ToNext);
            Text = "test";
        }

        void ToNext()
        {
            Debug.WriteLine("bind to tourContentViewModel");
        }
    }
}
