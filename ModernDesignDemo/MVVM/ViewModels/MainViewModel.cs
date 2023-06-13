using ModernDesignDemo.Core;

namespace ModernDesignDemo.MVVM.ViewModels
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand FeaturedViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public DiscoveryViewModel DiscoveryVm { get; set; }
        public FeaturedViewModel FeaturedVm { get; set; }

        private object currentView;
        public object CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            DiscoveryVm = new DiscoveryViewModel();
            FeaturedVm = new FeaturedViewModel();

            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVm; });
            DiscoveryViewCommand = new RelayCommand(o => { CurrentView = DiscoveryVm; });
            FeaturedViewCommand = new RelayCommand(o => { CurrentView = FeaturedVm; });
        }
    }
}