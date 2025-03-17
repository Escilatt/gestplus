using SoftUI.Core;
using SoftUI.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUI.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {


        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand AcercaViewCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }

        public AcercaDe AcercaVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            AcercaVM = new AcercaDe();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            AcercaViewCommand = new RelayCommand(o =>
            {
                CurrentView = AcercaVM;
            });


        }
    }
}
