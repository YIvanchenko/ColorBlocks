using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBlocksCore.Model
{
    public class Board
    {
        private readonly Tile[,] _tiles;

        public Board(int n, int m)
        {
            _tiles = new Tile[n, n];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    _tiles[i, j] = new Tile(random.Next(m));
                }
            }
        }
    }
}
