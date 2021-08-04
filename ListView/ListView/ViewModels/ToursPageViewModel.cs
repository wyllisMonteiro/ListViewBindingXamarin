using ListView.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListView.ViewModels
{
    class ToursPageViewModel
    {
        public TourContentViewModel tourContentVM { get; private set; }
        public List<Tour> ItemsSource { get; private set; }
        public bool LabelNbToursIsVisible { get; set; }
        public string LabelNbToursText { get; set; }
        
        public ToursPageViewModel()
        {
            LabelNbToursIsVisible = true;
            LabelNbToursText = "LabelNbToursText";
            ItemsSource = new List<Tour>();

            for (int index = 0; index < 10; index++)
            {
                var tour = NewTour(index);
                ItemsSource.Add(tour);
            }

            tourContentVM = new TourContentViewModel(ItemsSource);
        }

        private Tour NewTour(int id)
        {
            var tour = new Tour();
            tour.Id = id;
            tour.Title = "tour n°" + id;
            tour.Price = 5000;

            return tour;
        }
    }
}
