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
        
        public TicTacToe()
        {
            InitializeComponent();
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
            xoro += 1;
            if (xoro % 2 == 0)
            {
                nula.ImageSource = "X.jpg";
            }
            else
            {
                nula.ImageSource = "O.jpg";
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            xoro += 1;
            if (xoro % 2 == 0)
            {
                jedna.ImageSource = "X.jpg";
            }
            else
            {
                jedna.ImageSource = "O.jpg";
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            xoro += 1;
            if (xoro % 2 == 0)
            {
                dva.ImageSource = "X.jpg";
            }
            else
            {
                dva.ImageSource = "O.jpg";
            }
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            xoro += 1;
            if (xoro % 2 == 0)
            {
                tri.ImageSource = "X.jpg";
            }
            else
            {
                tri.ImageSource = "O.jpg";
            }
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            xoro += 1;
            if (xoro % 2 == 0)
            {
                styri.ImageSource = "X.jpg";
            }
            else
            {
                styri.ImageSource = "O.jpg";
            }
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            xoro += 1;
            if (xoro % 2 == 0)
            {
                pat.ImageSource = "X.jpg";
            }
            else
            {
                pat.ImageSource = "O.jpg";
            }
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            xoro += 1;
            if (xoro % 2 == 0)
            {
                sest.ImageSource = "X.jpg";
            }
            else
            {
                sest.ImageSource = "O.jpg";
            }
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            xoro += 1;
            if (xoro % 2 == 0)
            {
                sedem.ImageSource = "X.jpg";
            }
            else
            {
                sedem.ImageSource = "O.jpg";
            }
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            xoro += 1;
            if (xoro % 2 == 0)
            {
                osem.ImageSource = "X.jpg";
            }
            else
            {
                osem.ImageSource = "O.jpg";
            }
        }
    }
}