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
        bool allreadyclicked1 = false;
        bool allreadyclicked2 = false;
        bool allreadyclicked3 = false;
        bool allreadyclicked4 = false;
        bool allreadyclicked5 = false;
        bool allreadyclicked6 = false;
        bool allreadyclicked7 = false;
        bool allreadyclicked8 = false;
        bool allreadyclicked9 = false;

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
            allreadyclicked1 = false;
            allreadyclicked2 = false;
            allreadyclicked3 = false;
            allreadyclicked4 = false;
            allreadyclicked5 = false;
            allreadyclicked6 = false;
            allreadyclicked7 = false;
            allreadyclicked8 = false;
            allreadyclicked9 = false;
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

        public void Displayer(int boardIndex, Button button)
        {
                currentTurn++;
                gameBoard[boardIndex] = returnSymbol(currentTurn);
                if (gameBoard[boardIndex] == "X")
                {
                    button.ImageSource = "X.jpg";
                }
                else
                {
                    button.ImageSource = "O.jpg";
                }
                checkForWinner();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (allreadyclicked1 == false)
            {
                allreadyclicked1 = true;
                Displayer(0, button1);
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            if (allreadyclicked2 == false)
            {
                allreadyclicked2 = true;
                Displayer(1, button2);
            }
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            if (allreadyclicked3 == false)
            {
                allreadyclicked3 = true;
                Displayer(2, button3);
            }
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            if (allreadyclicked4 == false)
            {
                allreadyclicked4 = true;
                Displayer(3, button4);
            }
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            if (allreadyclicked5 == false)
            {
                allreadyclicked5 = true;
                Displayer(4, button5);
            }
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            if (allreadyclicked6 == false)
            {
                allreadyclicked6 = true;
                Displayer(5, button6);
            }
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            if (allreadyclicked7 == false)
            {
                allreadyclicked7 = true;
                Displayer(6, button7);
            }
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            if (allreadyclicked8 == false)
            {
                allreadyclicked8 = true;
                Displayer(7, button8);
            }
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            if (allreadyclicked9 == false)
            {
                allreadyclicked9 = true;
                Displayer(8, button9);
            }
        }
    }
}