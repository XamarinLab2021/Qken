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
        int rowWins = 0;
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
            Yourchoice.Source = "TheRock.jpg";
            Problem.Source = "";

            int opponentmove = random.Next(1, 4);

            if (opponentmove == 1)
            {
                Winlose.Text = "Draw";
                Problemchoice.Source = "TheRock.jpg";
                Compare.Source = "equals.png";
                rowWins = 0;
                RowWins.Text = rowWins.ToString();
            }
            else if (opponentmove == 2)
            {
                Winlose.Text = "Lose";
                Problemchoice.Source = "paper.jpg";
                Compare.Source = "right.png";
                rowWins = 0;
                RowWins.Text = rowWins.ToString();
                Problem.Source = "";
            }
            else
            {
                Winlose.Text = "Win";
                wins += 1;
                Wins.Text = wins.ToString();
                Problemchoice.Source = "scissors.jpg";
                Compare.Source = "left.png";
                rowWins += 1;
                RowWins.Text = rowWins.ToString();
            }
        }

        private void Button_Clicked_paper(object sender, EventArgs e)
        {
            Yourchoice.Source = "paper.jpg";
            Problem.Source = "";

            int opponentmove = random.Next(1, 4);

            if (opponentmove == 1)
            {
                Winlose.Text = "Win";
                wins += 1;
                Wins.Text = wins.ToString();
                Problemchoice.Source = "TheRock.jpg";
                Compare.Source = "left.png";
                rowWins += 1;
                RowWins.Text = rowWins.ToString();
            }
            else if (opponentmove == 2)
            {
                Winlose.Text = "Draw";
                Problemchoice.Source = "paper.jpg";
                Compare.Source = "equals.png";
                rowWins = 0;
                RowWins.Text = rowWins.ToString();
            }
            else
            {
                Winlose.Text = "Lose";
                Problemchoice.Source = "scissors.jpg";
                Compare.Source = "right.png";
                rowWins = 0;
                RowWins.Text = rowWins.ToString();
                Problem.Source = "";
            }
        }

        private void Button_Clicked_scissors(object sender, EventArgs e)
        {
            Yourchoice.Source = "scissors.jpg";
            Problem.Source = "";

            int opponentmove = random.Next(1, 4);

            if (opponentmove == 1)
            {
                Winlose.Text = "Lose";
                Problemchoice.Source = "TheRock.jpg";
                Compare.Source = "right.png";
                rowWins = 0;
                RowWins.Text = rowWins.ToString();
                Problem.Source = "";
            }
            else if (opponentmove == 2)
            {
                Winlose.Text = "Win";
                wins += 1;
                Wins.Text = wins.ToString();
                Problemchoice.Source = "paper.jpg";
                Compare.Source = "left.png";
                rowWins += 1;
                RowWins.Text = rowWins.ToString();
            }
            else
            {
                Winlose.Text = "Draw";
                Problemchoice.Source = "scissors.jpg";
                Compare.Source = "equals.png";
                rowWins = 0;
                RowWins.Text = rowWins.ToString();
            }
        }
       
    }
}