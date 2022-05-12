using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void Spar_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SparPage());
        }

        private async void Home_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomeAddress());
        }
    }
}