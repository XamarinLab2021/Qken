using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Qken2
{
    public class Skin
    {
        public ImageSource Cookie;
        public bool WasAlreadyClicked;
        public ImageSource SCookie;
        public Button Button;

        public Skin(string imageSource, string imagSource, Button but)
        {
            Cookie = imageSource;
            WasAlreadyClicked = false;
            SCookie = imagSource;
            Button = but;
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CookieClicker : ContentPage
    {

        int points = 0;
        int multiplaier = 1;
        bool allreadyClicked_1 = false;
        bool allreadyClicked_2 = false;
        private Skin skin1;
        private Skin skin2;
        private Skin skin3;
        private Skin skin4;
        public CookieClicker()
        {
            InitializeComponent();

            skin1 = new Skin("cookie1", "Scookie1", Button1);
            skin2 = new Skin("cookie2", "Scookie2", Button2);
            skin3 = new Skin("cookie3", "Scookie3", Button3);
            skin4 = new Skin("cookie4", "Scookie4", Button4);
        }
        
        public void SetSkinImageToCookieBtn(Skin skin)
        {
            if (skin.WasAlreadyClicked)
            {
                Cookie.ImageSource = skin.Cookie;
            }
            else if (points >= 10)
            {
                Cookie.ImageSource = skin.Cookie;
                skin.Button.ImageSource = skin.SCookie;
                skin.Button.Text = "";
                points -= 10;
                skin.WasAlreadyClicked = true;
            }
            else
            {
                DisplayAlert("You don't have enough cookies", "Cookies needed: 10", "OK");
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
            if (points >= 50 && allreadyClicked_1 == false)
            {
                points -= 50;
                multiplaier = 2;
                bigboost.Text = "X";
                allreadyClicked_1 = true;
            }
            else if (allreadyClicked_1 == false)
            {
                DisplayAlert("You don't have enough cookies", "Cookies needed: 50", "OK");
            }
            Points.Text = points.ToString();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            if (points >= 100 && allreadyClicked_2 == false)
            {
                points -= 50;
                multiplaier = 3;
                maxboost.Text = "X";
                allreadyClicked_2 = true;
            }
            else if (allreadyClicked_2 == false)
            {
                DisplayAlert("You don't have enough cookies", "Cookies needed: 100", "OK");
            }
            Points.Text = points.ToString();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            SetSkinImageToCookieBtn(skin1);
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            SetSkinImageToCookieBtn(skin2);
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            SetSkinImageToCookieBtn(skin3);
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            SetSkinImageToCookieBtn(skin4);
        }
    }
}