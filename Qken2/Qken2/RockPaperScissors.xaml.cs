﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Qken2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RockPaperScissors : ContentPage
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        }

        private void Button_Clickedback(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }

        private void Button_Clicked_virzdek(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_rock(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_paper(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_scissors(object sender, EventArgs e)
        {

        }
    }
}