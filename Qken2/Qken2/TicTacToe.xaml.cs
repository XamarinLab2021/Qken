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

        public TicTacToe()
        {
            InitializeComponent();
        }

        String[] gameBoard = new string[9];
        int currentTurn = 0;

        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public void checkForWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                String combination = "";

                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        break;
                }
                                
                if (combination.Equals("OOO"))
                {
                    reset();
                    DisplayAlert("Congratulations!", "O has won the game", "OK");
                }
                else if (combination.Equals("XXX"))
                {
                    reset();
                    DisplayAlert("Congratulations!", "X has won the game", "OK");
                }
                else { checkDraw(); }
               
            }
        }

        public void reset()
        {
            button1.ImageSource = "";
            button2.ImageSource = "";
            button3.ImageSource = "";
            button4.ImageSource = "";
            button5.ImageSource = "";
            button6.ImageSource = "";
            button7.ImageSource = "";
            button8.ImageSource = "";
            button9.ImageSource = "";
            gameBoard = new string[9];
            currentTurn = 0;
        }

        public void checkDraw()
        {
            int counter = 0;
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] != null)
                {
                    counter++;
                }
                if (counter == 9)
                {
                    reset();
                    DisplayAlert("Whaaat!", "It's a Draw!", "OK");
                }
            }
        }


        private void Button_ClickedBack(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[0] = returnSymbol(currentTurn);
            if (gameBoard[0] == "X")
            {
                button1.ImageSource = "X.jpg";
            }
            else
            {
                button1.ImageSource = "O.jpg";
            }
            checkForWinner();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[1] = returnSymbol(currentTurn);
            if (gameBoard[1] == "X")
            {
                button2.ImageSource = "X.jpg";
            }
            else
            {
                button2.ImageSource = "O.jpg";
            }
            checkForWinner();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[2] = returnSymbol(currentTurn);
            if (gameBoard[2] == "X")
            {
                button3.ImageSource = "X.jpg";
            }
            else
            {
                button3.ImageSource = "O.jpg";
            }
            checkForWinner();
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[3] = returnSymbol(currentTurn);
            if (gameBoard[3] == "X")
            {
                button4.ImageSource = "X.jpg";
            }
            else
            {
                button4.ImageSource = "O.jpg";
            }
            checkForWinner();
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[4] = returnSymbol(currentTurn);
            if (gameBoard[4] == "X")
            {
                button5.ImageSource = "X.jpg";
            }
            else
            {
                button5.ImageSource = "O.jpg";
            }
            checkForWinner();
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[5] = returnSymbol(currentTurn);
            if (gameBoard[5] == "X")
            {
                button6.ImageSource = "X.jpg";
            }
            else
            {
                button6.ImageSource = "O.jpg";
            }
            checkForWinner();
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[6] = returnSymbol(currentTurn);
            if (gameBoard[6] == "X")
            {
                button7.ImageSource = "X.jpg";
            }
            else
            {
                button7.ImageSource = "O.jpg";
            }
            checkForWinner();
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[7] = returnSymbol(currentTurn);
            if (gameBoard[7] == "X")
            {
                button8.ImageSource = "X.jpg";
            }
            else
            {
                button8.ImageSource = "O.jpg";
            }
            checkForWinner();
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[8] = returnSymbol(currentTurn);
            if (gameBoard[8] == "X")
            {
                button9.ImageSource = "X.jpg";
            }
            else
            {
                button9.ImageSource = "O.jpg";
            }
            checkForWinner();
        }
    }
}