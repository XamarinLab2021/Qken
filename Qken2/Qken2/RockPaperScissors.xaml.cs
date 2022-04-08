using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Qken2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RockPaperScissors : ContentPage
    {
        int wins = 0;
        Random random = new Random();

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
            Test.Source = "";

            int opponentmove = random.Next(1, 4);

            if (opponentmove == 1)
            {
                Opponent.Text = "Rock";
                Winlose.Text = "You Draw";
            }
            else if (opponentmove == 2)
            {
                Opponent.Text = "Paper";
                Winlose.Text = "You Lose";
                Test.Source = "problem.png";
            }
            else
            {
                Opponent.Text = "Scissors";
                Winlose.Text = "You Win";
                wins += 1;
                Wins.Text = wins.ToString();
            }
        }

        private void Button_Clicked_paper(object sender, EventArgs e)
        {
            Test.Source = "";

            int opponentmove = random.Next(1, 4);

            if (opponentmove == 1)
            {
                Opponent.Text = "Rock";
                Winlose.Text = "You Win";
                wins += 1;
                Wins.Text = wins.ToString();
            }
            else if (opponentmove == 2)
            {
                Opponent.Text = "Paper";
                Winlose.Text = "You Draw";
            }
            else
            {
                Opponent.Text = "Scissors";
                Winlose.Text = "You Lose";
                Test.Source = "problem.png";
            }
        }

        private void Button_Clicked_scissors(object sender, EventArgs e)
        {
            Test.Source = "";
            
            int opponentmove = random.Next(1, 4);

            if (opponentmove == 1)
            {
                Opponent.Text = "Rock";
                Winlose.Text = "You Lose";
                Test.Source = "problem.png";
            }
            else if (opponentmove == 2)
            {
                Opponent.Text = "Paper";
                Winlose.Text = "You Win";
                wins += 1;
                Wins.Text = wins.ToString();
            }
            else
            {
                Opponent.Text = "Scissors";
                Winlose.Text = "You Draw";
            }
        }
       
    }
}