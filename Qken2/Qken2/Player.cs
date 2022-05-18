namespace Qken2
{
    internal class Player
    {
        public string Name { get; set; }

        public int GuessedPairs { get; set; }

        public Player(string nameAtCreation)
        {
            Name = nameAtCreation;
            GuessedPairs = 0;
        }
    }
}
