using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace OffersApp
{
    partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "Angebote";

        [RelayCommand]
        private void Execute()
        {

        }
    }
}
