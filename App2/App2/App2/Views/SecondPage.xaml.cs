using App2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App2.Views
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage(string param)
        {
            InitializeComponent();
            BindingContext = new SecondViewModel(param);

        
        }
    }
}
