using System.Collections.Generic;

namespace Qken2
{
    internal class GamePexeso
    {
        List<Cell> cellList = new List<Cell>();
        List<Player> playerList = new List<Player>();

        public GamePexeso(List<Cell> cellListAtCreation)
        {
            cellList = cellListAtCreation;
        }

        public void AddPlayer(Player player)
        {
            playerList.Add(player);
        }

        public void FlipCells(Player player, Cell cell1, Cell cell2)
        {

        }
    }
}
