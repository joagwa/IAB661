using App1.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }

        public void OnClick(object sender, EventArgs e) {
            Navigation.PushAsync(new SecondPage("This is the second page (The easy way)"));
        }
    }

}
