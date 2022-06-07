using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Qken2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CookieClicker : ContentPage
    {

        int points = 0;
        int multiplaier = 1;
        bool allreadyClicked_1 = false;
        bool allreadyClicked_2 = false;
        bool cookieclicked1 = false;
        bool cookieclicked2 = false;
        bool cookieclicked3 = false;
        bool cookieclicked4 = false;

        public CookieClicker()
        {
            InitializeComponent();
            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.Indigo;
        }

        public void ImageSetter(ImageSource cookie, bool aclicked)
        {
            if (aclicked == true)
            {
                Cookie.ImageSource = cookie;
            }
            else if (points >= 1000)
            {
                Cookie.ImageSource = cookie;
                points -= 1000;
                aclicked = true;
            }
            else
            {
                DisplayAlert("You don't have enough cookies", "Cookies needed: 1000", "OK");
            }
            Points.Text = points.ToString();
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            points += multiplaier;
            Points.Text = points.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (points >= 100 && allreadyClicked_1 == false)
            {
                points -= 100;
                multiplaier = 2;
                bigboost.Text = "X";
                allreadyClicked_1 = true;
            }
            else if (allreadyClicked_1 == false)
            {
                DisplayAlert("You don't have enough cookies", "Cookies needed: 100", "OK");
            }
            Points.Text = points.ToString();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            if (points >= 500 && allreadyClicked_2 == false)
            {
                points -= 500;
                multiplaier = 3;
                maxboost.Text = "X";
                allreadyClicked_2 = true;
            }
            else if (allreadyClicked_2 == false)
            {
                DisplayAlert("You don't have enough cookies", "Cookies needed: 500", "OK");
            }
            Points.Text = points.ToString();
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            ImageSetter("cookie1", cookieclicked1);
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            ImageSetter("cookie2", cookieclicked2);
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            ImageSetter("cookie3", cookieclicked3);
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            ImageSetter("cookie4", cookieclicked4);
        }
    }
}