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
    public partial class TicTacToe : ContentPage
    {
        bool multiplayer = false;
        int xoro = 1;
        bool bzero = false;
        bool bone = false;
        bool btwo = false;
        bool bthree = false;
        bool bfour = false;
        bool bfive = false;
        bool bsix = false;
        bool bseven = false;
        bool beight = false;

        
        
        public TicTacToe()
        {
            InitializeComponent();
        }

        public void ImageDisplay()
        {
            xoro += 1;

            if (xoro % 2 == 0)
            {
                if (bzero == true)
                {
                    zero.ImageSource = "X.jpg";
                    bzero = false;
                }
                else if (bone == true)
                {
                    one.ImageSource = "X.jpg";
                    bone = false;
                }
                else if (btwo == true)
                {
                    two.ImageSource = "X.jpg";
                    btwo = false;
                }
                else if (bthree == true)
                {
                    three.ImageSource = "X.jpg";
                    bthree = false;
                }
                else if (bfour == true)
                {
                    four.ImageSource = "X.jpg";
                    bfour = false;
                }
                else if (bfive == true)
                {
                    five.ImageSource = "X.jpg";
                    bfive = false;
                }
                else if (bsix == true)
                {
                    six.ImageSource = "X.jpg";
                    bsix = false;
                }
                else if (bseven == true)
                {
                    seven.ImageSource = "X.jpg";
                    bseven = false;
                }
                else if (beight == true)
                {
                    eight.ImageSource = "X.jpg";
                    beight = false;
                }
            }
            else
            {
                if (bzero == true)
                {
                    zero.ImageSource = "O.jpg";
                    bzero = false;
                }
                else if (bone == true)
                {
                    one.ImageSource = "O.jpg";
                    bone = false;
                }
                else if (btwo == true)
                {
                    two.ImageSource = "O.jpg";
                    btwo = false;
                }
                else if (bthree == true)
                {
                    three.ImageSource = "O.jpg";
                    bthree = false;
                }
                else if (bfour == true)
                {
                    four.ImageSource = "O.jpg";
                    bfour = false;
                }
                else if (bfive == true)
                {
                    five.ImageSource = "O.jpg";
                    bfive = false;
                }
                else if (bsix == true)
                {
                    six.ImageSource = "O.jpg";
                    bsix = false;
                }
                else if (bseven == true)
                {
                    seven.ImageSource = "O.jpg";
                    bseven = false;
                }
                else if (beight == true)
                {
                    eight.ImageSource = "O.jpg";
                    beight = false;
                }
            }
        }

        private void Button_ClickedBack(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }

        private void Button_ClickedMulti(object sender, EventArgs e)
        {
            multiplayer = false;
        }

        private void Button_ClickedSingle(object sender, EventArgs e)
        {
            multiplayer = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            bzero = true;
            ImageDisplay();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
            bone = true;
            ImageDisplay();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            
            btwo = true;
            ImageDisplay();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            
            bthree = true;
            ImageDisplay();
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            
            bfour = true;
            ImageDisplay();
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            
            bfive = true;
            ImageDisplay();
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            
            bsix = true;
            ImageDisplay();
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            
            bseven = true;
            ImageDisplay();
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            
            beight = true;
            ImageDisplay();
        }
    }
}