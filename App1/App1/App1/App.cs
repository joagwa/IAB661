﻿using App1.Implementations;
using App1.Views;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class App : Application
    {
        public App()
        {

            var nav = new NavigationService();
            nav.Configure(Locator.MainPage, typeof(MainPage));
            nav.Configure(Locator.SecondPage, typeof(SecondPage));
            SimpleIoc.Default.Register<INavigationService>(()=>nav);

            var mainPage = new NavigationPage(new MainPage());
            nav.Initialize(mainPage);
            // The root page of your application
            MainPage = mainPage;  

            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
