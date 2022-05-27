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

        
        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DudoClicker());
        }

        async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RockPaperScissors());
        }

        async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TicTacToe());
        }

        async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pexeso());
        }
    }
}
