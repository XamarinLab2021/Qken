using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Qken2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(2000);
            await Task.WhenAll(
                SplashGrid.FadeTo(0, 2000),
                Logo.ScaleTo(10, 2000)
                );
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DudoClicker());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new RockPaperScissors());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new TicTacToe());
        }
    }
}
