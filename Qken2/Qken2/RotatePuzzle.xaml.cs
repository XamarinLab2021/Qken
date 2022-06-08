using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Qken2
{
    public class Block
    {
        public ImageButton Button;
        public int Angle;

        public Block(ImageButton imageButton, int angle)
        {
            Button = imageButton;
            Angle = angle;
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RotatePuzzle : ContentPage
    {

        private Block block1;
        private Block block2;
        private Block block3;
        private Block block4;
        private Block block5;
        private Block block6;
        private Block block7;
        private Block block8;
        private Block block9;
        private Block block10;
        private Block block11;
        private Block block12;
        private Block block13;
        private Block block14;
        private Block block15;
        private Block block16;

        int currentAngle1 = 0;
        int currentAngle2 = 0;
        int currentAngle3 = 0;
        int currentAngle4 = 0;
        int currentAngle5 = 0;
        int currentAngle6 = 0;
        int currentAngle7 = 0;
        int currentAngle8 = 0;
        int currentAngle9 = 0;
        int currentAngle10 = 0;
        int currentAngle11 = 0;
        int currentAngle12 = 0;
        int currentAngle13 = 0;
        int currentAngle14 = 0;
        int currentAngle15 = 0;
        int currentAngle16 = 0;

        public RotatePuzzle()
        {
            InitializeComponent();
            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.Indigo;

            Shuffle();

            block1 = new Block(Rotate1, currentAngle1);
            block2 = new Block(Rotate2, currentAngle2);
            block3 = new Block(Rotate3, currentAngle3);
            block4 = new Block(Rotate4, currentAngle4);
            block5 = new Block(Rotate5, currentAngle5);
            block6 = new Block(Rotate6, currentAngle6);
            block7 = new Block(Rotate7, currentAngle7);
            block8 = new Block(Rotate8, currentAngle8);
            block9 = new Block(Rotate9, currentAngle9);
            block10 = new Block(Rotate10, currentAngle10);
            block11 = new Block(Rotate11, currentAngle11);
            block12 = new Block(Rotate12, currentAngle12);
            block13 = new Block(Rotate13, currentAngle13);
            block14 = new Block(Rotate14, currentAngle14);
            block15 = new Block(Rotate15, currentAngle15);
            block16 = new Block(Rotate16, currentAngle16);
        }

        public void Shuffle()
        {
            
        }


        public void WinChecker()
        {
            if (block1.Angle == 0 && block2.Angle == 0 && block3.Angle == 0 && block4.Angle == 0 && block5.Angle == 0 && block6.Angle == 0 &&
                block7.Angle == 0 && block8.Angle == 0 && block9.Angle == 0 && block10.Angle == 0 && block11.Angle == 0 && block12.Angle == 0 &&
                block13.Angle == 0 && block14.Angle == 0 && block15.Angle == 0 && block16.Angle == 0)
            {
                DisplayAlert("Congratulations!", "You have won Rotate Puzzle", "OK");
                Shuffle();
            }
        }

        public void Rotator(Block block)
        {
            block.Angle += 90;
            block.Button.RotateTo(block.Angle);
            if (block.Angle == 360)
            {
                block.Angle = 0;
            }
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            Rotator(block1);
            WinChecker();
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            Rotator(block2);
            WinChecker();
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            Rotator(block3);
            WinChecker();
        }

        private void Button_Clicked4(object sender, EventArgs e)
        {
            Rotator(block4);
            WinChecker();
        }

        private void Button_Clicked5(object sender, EventArgs e)
        {
            Rotator(block5);
            WinChecker();
        }

        private void Button_Clicked6(object sender, EventArgs e)
        {
            Rotator(block6);
            WinChecker();
        }

        private void Button_Clicked7(object sender, EventArgs e)
        {
            Rotator(block7);
            WinChecker();
        }

        private void Button_Clicked8(object sender, EventArgs e)
        {
            Rotator(block8);
            WinChecker();
        }

        private void Button_Clicked9(object sender, EventArgs e)
        {
            Rotator(block9);
            WinChecker();
        }

        private void Button_Clicked10(object sender, EventArgs e)
        {
            Rotator(block10);
            WinChecker();
        }

        private void Button_Clicked11(object sender, EventArgs e)
        {
            Rotator(block11);
            WinChecker();
        }

        private void Button_Clicked12(object sender, EventArgs e)
        {
            Rotator(block12);
            WinChecker();
        }

        private void Button_Clicked13(object sender, EventArgs e)
        {
            Rotator(block13);
            WinChecker();
        }

        private void Button_Clicked14(object sender, EventArgs e)
        {
            Rotator(block14);
            WinChecker();
        }

        private void Button_Clicked15(object sender, EventArgs e)
        {
            Rotator(block15);
            WinChecker();
        }

        private void Button_Clicked16(object sender, EventArgs e)
        {
            Rotator(block16);
            WinChecker();
        }
    }
}