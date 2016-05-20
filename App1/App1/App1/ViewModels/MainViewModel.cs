using App1.Implementations;
using App1.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string buttonLabel;

        public string ButtonLabel
        {
            get { return buttonLabel; }
            set { buttonLabel = value;
                RaisePropertyChanged(() => ButtonLabel);
            }
        }
        INavigationService _navigationservice;
        public ICommand ButtonCommand { get; private set; }
        public MainViewModel(INavigationService navigationService) {
            _navigationservice = navigationService;
            ButtonLabel = "Move to next page";
            ButtonCommand = new Command(() => 
            _navigationservice.NavigateTo(Locator.SecondPage, "This is the second Page"));
        }

    }
}
