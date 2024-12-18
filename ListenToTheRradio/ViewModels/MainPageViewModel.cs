using CommunityToolkit.Mvvm.ComponentModel;
using ListenToTheRradio.Views;
using System.Collections.ObjectModel;

namespace ListenToTheRradio.ViewModels
{

    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ContentView> _pageList = new ObservableCollection<ContentView>();


        public MainPageViewModel()
        {
            PageList.Add(new PageOne());
            PageList.Add(new PageTwo());
            PageList.Add(new PageThree());
        }
    }
}
