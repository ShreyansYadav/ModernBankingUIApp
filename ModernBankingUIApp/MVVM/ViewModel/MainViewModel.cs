using ModernBankingApp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModernBankingUIApp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {


        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public RelayCommand SettingsView { get; set; }
        public SettingsViewCommand SettingsVM { get; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertChanged();
            }
        }

        
        public MainViewModel()
        {
            SettingsVM = new SettingsViewCommand();
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            CurrentView = HomeVM;   

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });

            SettingsView = new RelayCommand(o =>
            {
                CurrentView = SettingsVM;
            });
        }
    }
}
