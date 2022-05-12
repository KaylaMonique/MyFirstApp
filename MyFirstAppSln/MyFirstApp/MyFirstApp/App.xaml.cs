using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new SplashScreen());

            MainPage = navPage;
        }
    }
}
