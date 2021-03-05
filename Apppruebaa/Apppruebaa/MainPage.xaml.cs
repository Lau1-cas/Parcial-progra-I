using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Apppruebaa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnpag2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Segunda());

        }

        private async void btnpag3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tercera());
        }
    }
}
