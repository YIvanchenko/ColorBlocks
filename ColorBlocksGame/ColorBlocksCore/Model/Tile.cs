using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBlocksCore.Model
{
    public class Tile
    {
        public Tile(int color)
        {
            Color = color;
        }

        public int Color { get; private set; }
    }
}
