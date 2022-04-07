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
    public partial class RockPaperScissors : ContentPage
    {
        int wins = 0;
        public RockPaperScissors()
        {
            InitializeComponent();
        }
       
       private void Button_Clickedback(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
        private void Button_Clicked_rock(object sender, EventArgs e)
        {
            Random random = new Random();
            int opponentmove = random.Next(1, 4);

            if (opponentmove == 1)
            {
                Opponent.Text = "Rock";
            }
            else if (opponentmove == 2)
            {
                Opponent.Text = "Paper";
            }
            else
            {
                Opponent.Text = "Scissors";
            }

            if (opponentmove == 1)
            {
                Winlose.Text = "You Draw";
            }
            else if (opponentmove == 2)
            {
                Winlose.Text = "You Lose";
            }
            else
            {
                 Winlose.Text = "You Win";
                wins += 1;
                Wins.Text = wins.ToString();
            }
            
        }

        private void Button_Clicked_paper(object sender, EventArgs e)
        {
            Random random = new Random();
            int opponentmove = random.Next(1, 4);

            if (opponentmove == 1)
            {
                Opponent.Text = "Rock";
            }
            else if (opponentmove == 2)
            {
                Opponent.Text = "Paper";
            }
            else
            {
                Opponent.Text = "Scissors";
            }

            if (opponentmove == 1)
            {
                Winlose.Text = "You Win";
                wins += 1;
                Wins.Text = wins.ToString();
            }
            else if (opponentmove == 2)
            {
                Winlose.Text = "You Draw";
            }
            else
            {
                Winlose.Text = "You Lose";
            }
        }

        private void Button_Clicked_scissors(object sender, EventArgs e)
        {
            Random random = new Random();
            int opponentmove = random.Next(1, 4);

            if (opponentmove == 1)
            {
                Opponent.Text = "Rock";
            }
            else if (opponentmove == 2)
            {
                Opponent.Text = "Paper";
            }
            else
            {
                Opponent.Text = "Scissors";
            }

            if (opponentmove == 1)
            {
                Winlose.Text = "You Lose";
            }
            else if (opponentmove == 2)
            {
                Winlose.Text = "You Win";
                wins += 1;
                Wins.Text = wins.ToString();
            }
            else
            {
                Winlose.Text = "You Draw";
            }
        }
       
    }
}