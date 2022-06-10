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

        public Block(ImageButton imageButton)
        {
            Button = imageButton;
            Angle = 0;
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RotatePuzzle : ContentPage
    {
        List<Block> blocks;

        public RotatePuzzle()
        {
            InitializeComponent();
            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.Indigo;

            blocks = new List<Block>();
            blocks.Add(new Block(Rotate1));
            blocks.Add(new Block(Rotate2));
            blocks.Add(new Block(Rotate3));
            blocks.Add(new Block(Rotate4));
            blocks.Add(new Block(Rotate5));
            blocks.Add(new Block(Rotate6));
            blocks.Add(new Block(Rotate7));
            blocks.Add(new Block(Rotate8));
            blocks.Add(new Block(Rotate9));
            blocks.Add(new Block(Rotate10));
            blocks.Add(new Block(Rotate11));
            blocks.Add(new Block(Rotate12));
            blocks.Add(new Block(Rotate13));
            blocks.Add(new Block(Rotate14));
            blocks.Add(new Block(Rotate15));
            blocks.Add(new Block(Rotate16));

            Shuffle();
        }

        private void Shuffle()
        {
            var random = new Random();
            foreach (var block in blocks)
            {
                block.Angle = random.Next(0, 4) * 90;
                block.Button.RotateTo(block.Angle);
            }
        }

        private void WinChecker()
        {
            if (blocks.Any(block => block.Angle % 360 != 0))
            {
                return;
            }

            DisplayAlert("Congratulations!", "You have won Rotate Puzzle", "OK");
            Shuffle();
        }

        private void Rotate90Degrees(Block block)
        {
            block.Angle += 90;
            block.Button.RotateTo(block.Angle);
        }

        private void HandleButtonClicked(int blockIndex)
        {
            Rotate90Degrees(blocks[blockIndex]);
            WinChecker();
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            HandleButtonClicked(0);
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            HandleButtonClicked(1);
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            HandleButtonClicked(2);
        }

        private void Button_Clicked4(object sender, EventArgs e)
        {
            HandleButtonClicked(3);
        }

        private void Button_Clicked5(object sender, EventArgs e)
        {
            HandleButtonClicked(4);
        }

        private void Button_Clicked6(object sender, EventArgs e)
        {
            HandleButtonClicked(5);
        }

        private void Button_Clicked7(object sender, EventArgs e)
        {
            HandleButtonClicked(6);
        }

        private void Button_Clicked8(object sender, EventArgs e)
        {
            HandleButtonClicked(7);
        }

        private void Button_Clicked9(object sender, EventArgs e)
        {
            HandleButtonClicked(8);
        }

        private void Button_Clicked10(object sender, EventArgs e)
        {
            HandleButtonClicked(9);
        }

        private void Button_Clicked11(object sender, EventArgs e)
        {
            HandleButtonClicked(10);
        }

        private void Button_Clicked12(object sender, EventArgs e)
        {
            HandleButtonClicked(11); 
        }

        private void Button_Clicked13(object sender, EventArgs e)
        {
            HandleButtonClicked(12);
        }

        private void Button_Clicked14(object sender, EventArgs e)
        {
            HandleButtonClicked(13);
        }

        private void Button_Clicked15(object sender, EventArgs e)
        {
            HandleButtonClicked(14);
        }

        private void Button_Clicked16(object sender, EventArgs e)
        {
            HandleButtonClicked(15);
        }
    }
}