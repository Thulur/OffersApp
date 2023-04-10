using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OffersApp.Endpoints;
using OffersApp.Offers;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OffersApp
{
    partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<IOffer> offers = new();

        public MainViewModel()
        {
            OfferGatherer.Init();
        }

        [RelayCommand]
        private async void LoadOffers()
        {
            Offers.Clear();
            var newOffers = await OfferGatherer.Gather();
            foreach (IOffer offer in newOffers)
            {
                Offers.Add(offer);
            }
        }
    }
}
