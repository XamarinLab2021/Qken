using System.Globalization;
using System.Drawing;

namespace Qken2
{
    internal class Cell
    {
        public int Number { get; set; }
        public bool Flipped { get; set; }
        public bool StayFlipped { get; set; }
        public string ImagePath { get; set; }

        public Cell(int numberAtCreation, string imagePathAtCreation)
        {
            Number = numberAtCreation;
            ImagePath = imagePathAtCreation;
            Flipped = false;
            StayFlipped = false;
        }
    }
}
