using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App2.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string buttonText;

        public string ButtonText
        {
            get { return buttonText; }
            set { buttonText = value;
                RaisePropertyChanged(()=>ButtonText);
            }
        }

        private string entryText;

        public string EntryText
        {
            get { return entryText; }
            set { entryText = value;
                RaisePropertyChanged(() => EntryText);
            }
        }

        private INavigationService _navigationService;
        public ICommand ButtonCommand { get; private set; }
        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            ButtonText = "Move to next page";
            ButtonCommand = new Command (()=> 
            _navigationService.NavigateTo(Locator.SecondPage, EntryText));
        }

       
    }
}
