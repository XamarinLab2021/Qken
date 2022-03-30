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
    public partial class DudoClicker : ContentPage
    {
        int Dudcoin = 0;
        int x = 1;
        int i = 0;
        int j = 0;
        
        public DudoClicker()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Dudcoin += x;
            Dudpoints.Text = Dudcoin.ToString();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            if (Dudcoin >= 100)
            {
                i += 1;
                if (i <= 1)
                {
                    Dudcoin -= 100;
                    x = 2;
                }
            }
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            if (Dudcoin >= 500)
            {
                j += 1;
                if (j <= 1)
                {
                    Dudcoin -= 500;
                    x = 3;
                }
            }
        }
    }
}
